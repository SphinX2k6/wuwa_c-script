using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using UnrealEngine;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace Aki.Common
{
	// Token: 0x0200001B RID: 27
	[ConsoleVariableBool("cs.JitProfile.Disable", false, "Disable JitProfile", EConsoleVariableFlags.ECVF_Default)]
	[ConsoleVariableBool("cs.JitProfile.FrameSplit", true, "Enable JitProfile frameSplit mode, if true, async will disable", EConsoleVariableFlags.ECVF_Default)]
	[ConsoleVariableInt("cs.JitProfile.FrameSplitBatch", 100, "JitProfile frameSplit batch job count", EConsoleVariableFlags.ECVF_Default)]
	public class JitProfile
	{
		// Token: 0x06000128 RID: 296 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
		[NullableContext(1)]
		public static void LoadProfile(string BinProfilePath)
		{
			if (JitProfile.HasInvoked)
			{
				return;
			}
			JitProfile.HasInvoked = true;
			if (JitProfile.Get_cs_JitProfile_Disable())
			{
				UnrealLogger.Info("JitProfile: Disable by variable");
				return;
			}
			if (UKismetSystemLibrary.GetCommandLine().Contains("-DisableJitProfile", StringComparison.OrdinalIgnoreCase))
			{
				UnrealLogger.Info("JitProfile: Disable by commandLine");
				return;
			}
			UnrealLogger.Info("JitProfile: Start");
			Stopwatch stopwatch = Stopwatch.StartNew();
			TArray<byte> tarray = JitProfile.LoadBinProfile(BinProfilePath);
			if (tarray == null || tarray.Num() == 0)
			{
				return;
			}
			bool cs_JitProfile_FrameSplit = JitProfile.Get_cs_JitProfile_FrameSplit();
			bool flag = false;
			bool drop = false;
			JitProfile.Job = new JitProfile.JitJobs(cs_JitProfile_FrameSplit, flag, drop);
			JitProfile.Job.Run(tarray);
			stopwatch.Stop();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 3);
			defaultInterpolatedStringHandler.AppendLiteral("JitProfile: Use Time: ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(stopwatch.ElapsedMilliseconds);
			defaultInterpolatedStringHandler.AppendLiteral("ms Async:");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag);
			defaultInterpolatedStringHandler.AppendLiteral(" FrameSplit:");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(cs_JitProfile_FrameSplit);
			UnrealLogger.Info(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000E8CE File Offset: 0x0000CACE
		public static void StopProfileAsync()
		{
			JitProfile.JitJobs jitJobs = Interlocked.Exchange<JitProfile.JitJobs>(ref JitProfile.Job, null);
			if (jitJobs == null)
			{
				return;
			}
			jitJobs.Stop();
		}

		// Token: 0x0600012A RID: 298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool Internal_Load(char* Path, IntPtr OutData);

		// Token: 0x0600012B RID: 299 RVA: 0x0000E8E8 File Offset: 0x0000CAE8
		[NullableContext(1)]
		[return: Nullable(2)]
		private unsafe static TArray<byte> LoadBinProfile(string BinProfilePath)
		{
			if (string.IsNullOrEmpty(BinProfilePath))
			{
				return null;
			}
			TArray<byte> tarray = new TArray<byte>();
			char* path;
			if (BinProfilePath == null)
			{
				path = null;
			}
			else
			{
				fixed (char* ptr = BinProfilePath.GetPinnableReference())
				{
					path = ptr;
				}
			}
			if (!JitProfile.Internal_Load(path, tarray.NativePtr))
			{
				tarray.Dispose();
				return null;
			}
			char* ptr = null;
			return tarray;
		}

		// Token: 0x0600012C RID: 300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_RequestFrameSplit();

		// Token: 0x0600012D RID: 301 RVA: 0x0000E92E File Offset: 0x0000CB2E
		internal static void OnFrameSplit(out bool Finish)
		{
			Finish = (JitProfile.Job == null || JitProfile.Job.FrameSplitWork());
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000E946 File Offset: 0x0000CB46
		public static bool Get_cs_JitProfile_Disable()
		{
			return IConsoleManager.GetConsoleBoolVariable("cs.JitProfile.Disable");
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000E952 File Offset: 0x0000CB52
		public static bool Set_cs_JitProfile_Disable(bool Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return IConsoleManager.SetConsoleVariable("cs.JitProfile.Disable", Value, Flags);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000E960 File Offset: 0x0000CB60
		public static bool Get_cs_JitProfile_FrameSplit()
		{
			return IConsoleManager.GetConsoleBoolVariable("cs.JitProfile.FrameSplit");
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000E96C File Offset: 0x0000CB6C
		public static bool Set_cs_JitProfile_FrameSplit(bool Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return IConsoleManager.SetConsoleVariable("cs.JitProfile.FrameSplit", Value, Flags);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000E97A File Offset: 0x0000CB7A
		public static int Get_cs_JitProfile_FrameSplitBatch()
		{
			return IConsoleManager.GetConsoleIntVariable("cs.JitProfile.FrameSplitBatch");
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000E986 File Offset: 0x0000CB86
		public static bool Set_cs_JitProfile_FrameSplitBatch(int Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return IConsoleManager.SetConsoleVariable("cs.JitProfile.FrameSplitBatch", Value, Flags);
		}

		// Token: 0x04000224 RID: 548
		private static bool HasInvoked;

		// Token: 0x04000225 RID: 549
		[Nullable(2)]
		private static JitProfile.JitJobs Job;

		// Token: 0x02000066 RID: 102
		[NullableContext(2)]
		[Nullable(0)]
		private sealed class JitJobs
		{
			// Token: 0x06000276 RID: 630 RVA: 0x00011F06 File Offset: 0x00010106
			public JitJobs(bool frameSplit, bool async = false, bool drop = false)
			{
				if (async || frameSplit)
				{
					this.Cts = new CancellationTokenSource();
				}
				this.IsFrameSplit = frameSplit;
			}

			// Token: 0x06000277 RID: 631 RVA: 0x00011F38 File Offset: 0x00010138
			public void Stop()
			{
				CancellationTokenSource cts = this.Cts;
				if (cts != null)
				{
					cts.Cancel();
				}
				if (this.NumTotal > 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral("JitProfile: Finish: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumJit);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumTotal);
					UnrealLogger.Info(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}

			// Token: 0x06000278 RID: 632 RVA: 0x00011FA8 File Offset: 0x000101A8
			[NullableContext(1)]
			public void Run(TArray<byte> binProfile)
			{
				try
				{
					ReadOnlySpan<byte> readOnlySpan = binProfile.AsSpan<byte>();
					this.NumTotal = MemoryMarshal.Read<int>(readOnlySpan);
					if (this.NumTotal <= 0)
					{
						if (this.NumTotal < 0)
						{
							UnrealLogger.ErrorNoTrace("JitProfile: Fail bad format NumTotal");
						}
						JitProfile.StopProfileAsync();
					}
					else
					{
						this.Offset = 4;
						if (this.IsFrameSplit)
						{
							this.Buffer = binProfile;
							JitProfile.Internal_RequestFrameSplit();
						}
						else
						{
							this.ReadBinBufferAndJitJob(readOnlySpan, ref this.Index, ref this.Offset, int.MaxValue);
							JitProfile.StopProfileAsync();
						}
					}
				}
				catch (Exception value)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("JitProfile: Fail bad format ");
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					UnrealLogger.ErrorNoTrace(defaultInterpolatedStringHandler.ToStringAndClear());
					JitProfile.StopProfileAsync();
				}
			}

			// Token: 0x06000279 RID: 633 RVA: 0x00012070 File Offset: 0x00010270
			public bool FrameSplitWork()
			{
				try
				{
					if (this.Cts.IsCancellationRequested || this.ReadBinBufferAndJitJob(this.Buffer.AsSpan<byte>(), ref this.Index, ref this.Offset, this.FrameSplitBatch))
					{
						JitProfile.StopProfileAsync();
						return true;
					}
				}
				catch (Exception value)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
					defaultInterpolatedStringHandler.AppendLiteral("JitProfile: FrameSplit Exception ");
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					UnrealLogger.ErrorNoTrace(defaultInterpolatedStringHandler.ToStringAndClear());
					JitProfile.StopProfileAsync();
					return true;
				}
				return false;
			}

			// Token: 0x0600027A RID: 634 RVA: 0x00012108 File Offset: 0x00010308
			[NullableContext(0)]
			private bool ReadBinBufferAndJitJob(ReadOnlySpan<byte> buffer, ref int index, ref int offset, int maxNumToRead = 2147483647)
			{
				int num = 0;
				while (index < this.NumTotal && num < maxNumToRead)
				{
					int num2 = MemoryMarshal.Read<int>(buffer.Slice(offset, 4));
					offset += 4;
					int num3 = MemoryMarshal.Read<int>(buffer.Slice(offset, 4));
					offset += 4;
					string @string = Encoding.UTF8.GetString(buffer.Slice(offset, num2));
					offset += num2;
					string string2 = Encoding.UTF8.GetString(buffer.Slice(offset, num3));
					offset += num3;
					if (this.JitEntry(@string, string2))
					{
						this.NumJit++;
					}
					index++;
					num++;
				}
				return index >= this.NumTotal;
			}

			// Token: 0x0600027B RID: 635 RVA: 0x000121C4 File Offset: 0x000103C4
			[NullableContext(1)]
			private bool JitEntry(string className, string method)
			{
				try
				{
					Type type;
					if (className == this.LastTypeName)
					{
						type = this.LastType;
					}
					else
					{
						type = (this.LastType = Type.GetType(className));
						this.LastTypeName = className;
					}
					if (type != null)
					{
						RuntimeHelpers.RunClassConstructor(type.TypeHandle);
						return JitProfile.JitJobs.JitJob(type, method);
					}
				}
				catch (Exception value)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
					defaultInterpolatedStringHandler.AppendLiteral("JitProfile: Fail Exception ");
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					UnrealLogger.Info(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				return false;
			}

			// Token: 0x0600027C RID: 636 RVA: 0x00012260 File Offset: 0x00010460
			[NullableContext(1)]
			private static bool JitJob(Type type, string method)
			{
				if (method == ".ctor")
				{
					ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if (constructors.Length != 0)
					{
						ConstructorInfo[] array = constructors;
						for (int i = 0; i < array.Length; i++)
						{
							RuntimeHelpers.PrepareMethod(array[i].MethodHandle);
						}
						return true;
					}
				}
				else
				{
					MemberInfo[] member = type.GetMember(method, MemberTypes.Method, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
					if (member.Length != 0)
					{
						MemberInfo[] array2 = member;
						for (int i = 0; i < array2.Length; i++)
						{
							MethodInfo methodInfo = array2[i] as MethodInfo;
							if (methodInfo != null && !methodInfo.ContainsGenericParameters)
							{
								RuntimeHelpers.PrepareMethod(methodInfo.MethodHandle);
							}
						}
						return true;
					}
				}
				return false;
			}

			// Token: 0x04000328 RID: 808
			private int NumTotal;

			// Token: 0x04000329 RID: 809
			private int NumJit;

			// Token: 0x0400032A RID: 810
			private readonly CancellationTokenSource Cts;

			// Token: 0x0400032B RID: 811
			private int Index;

			// Token: 0x0400032C RID: 812
			private int Offset;

			// Token: 0x0400032D RID: 813
			private readonly bool IsFrameSplit;

			// Token: 0x0400032E RID: 814
			private TArray<byte> Buffer;

			// Token: 0x0400032F RID: 815
			private readonly int FrameSplitBatch = Math.Max(10, JitProfile.Get_cs_JitProfile_FrameSplitBatch());

			// Token: 0x04000330 RID: 816
			private string LastTypeName;

			// Token: 0x04000331 RID: 817
			private Type LastType;
		}
	}
}
