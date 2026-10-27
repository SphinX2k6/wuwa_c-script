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
	// Token: 0x0200001A RID: 26
	[ConsoleVariableBool("cs.JitProfile.Disable", false, "Disable JitProfile", EConsoleVariableFlags.ECVF_Default)]
	[ConsoleVariableBool("cs.JitProfile.FrameSplit", true, "Enable JitProfile frameSplit mode, if true, async will disable", EConsoleVariableFlags.ECVF_Default)]
	[ConsoleVariableInt("cs.JitProfile.FrameSplitBatch", 100, "JitProfile frameSplit batch job count", EConsoleVariableFlags.ECVF_Default)]
	public class JitProfile
	{
		// Token: 0x060000BB RID: 187 RVA: 0x0000B038 File Offset: 0x00009238
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
			UnrealLogger.Info("JitProfile: Start");
			Stopwatch stopwatch = Stopwatch.StartNew();
			TArray<byte> tarray = JitProfile.LoadBinProfile(BinProfilePath);
			if (tarray == null || tarray.Num() == 0)
			{
				return;
			}
			bool cs_JitProfile_FrameSplit = JitProfile.Get_cs_JitProfile_FrameSplit();
			bool flag = false;
			JitProfile.Job = new JitProfile.JitJobs(cs_JitProfile_FrameSplit, flag);
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

		// Token: 0x060000BC RID: 188 RVA: 0x0000B104 File Offset: 0x00009304
		public static void StopProfileAsync()
		{
			JitProfile.JitJobs jitJobs = Interlocked.Exchange<JitProfile.JitJobs>(ref JitProfile.Job, null);
			if (jitJobs == null)
			{
				return;
			}
			jitJobs.Stop();
		}

		// Token: 0x060000BD RID: 189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool Internal_Load(char* Path, IntPtr OutData);

		// Token: 0x060000BE RID: 190 RVA: 0x0000B11C File Offset: 0x0000931C
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

		// Token: 0x060000BF RID: 191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_RequestFrameSplit();

		// Token: 0x060000C0 RID: 192 RVA: 0x0000B162 File Offset: 0x00009362
		internal static void OnFrameSplit(out bool Finish)
		{
			Finish = (JitProfile.Job == null || JitProfile.Job.FrameSplitWork());
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000B17A File Offset: 0x0000937A
		public static bool Get_cs_JitProfile_Disable()
		{
			return IConsoleManager.GetConsoleBoolVariable("cs.JitProfile.Disable");
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000B186 File Offset: 0x00009386
		public static bool Set_cs_JitProfile_Disable(bool Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return IConsoleManager.SetConsoleVariable("cs.JitProfile.Disable", Value, Flags);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000B194 File Offset: 0x00009394
		public static bool Get_cs_JitProfile_FrameSplit()
		{
			return IConsoleManager.GetConsoleBoolVariable("cs.JitProfile.FrameSplit");
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000B1A0 File Offset: 0x000093A0
		public static bool Set_cs_JitProfile_FrameSplit(bool Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return IConsoleManager.SetConsoleVariable("cs.JitProfile.FrameSplit", Value, Flags);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000B1AE File Offset: 0x000093AE
		public static int Get_cs_JitProfile_FrameSplitBatch()
		{
			return IConsoleManager.GetConsoleIntVariable("cs.JitProfile.FrameSplitBatch");
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000B1BA File Offset: 0x000093BA
		public static bool Set_cs_JitProfile_FrameSplitBatch(int Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return IConsoleManager.SetConsoleVariable("cs.JitProfile.FrameSplitBatch", Value, Flags);
		}

		// Token: 0x0400021F RID: 543
		private static bool HasInvoked;

		// Token: 0x04000220 RID: 544
		[Nullable(2)]
		private static JitProfile.JitJobs Job;

		// Token: 0x02000044 RID: 68
		[NullableContext(2)]
		[Nullable(0)]
		private sealed class JitJobs
		{
			// Token: 0x0600013A RID: 314 RVA: 0x0000C2F6 File Offset: 0x0000A4F6
			public JitJobs(bool frameSplit, bool async = false)
			{
				if (async || frameSplit)
				{
					this.Cts = new CancellationTokenSource();
				}
				this.IsFrameSplit = frameSplit;
			}

			// Token: 0x0600013B RID: 315 RVA: 0x0000C328 File Offset: 0x0000A528
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

			// Token: 0x0600013C RID: 316 RVA: 0x0000C398 File Offset: 0x0000A598
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

			// Token: 0x0600013D RID: 317 RVA: 0x0000C460 File Offset: 0x0000A660
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

			// Token: 0x0600013E RID: 318 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
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

			// Token: 0x0600013F RID: 319 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
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

			// Token: 0x06000140 RID: 320 RVA: 0x0000C650 File Offset: 0x0000A850
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

			// Token: 0x040002A0 RID: 672
			private int NumTotal;

			// Token: 0x040002A1 RID: 673
			private int NumJit;

			// Token: 0x040002A2 RID: 674
			private readonly CancellationTokenSource Cts;

			// Token: 0x040002A3 RID: 675
			private int Index;

			// Token: 0x040002A4 RID: 676
			private int Offset;

			// Token: 0x040002A5 RID: 677
			private readonly bool IsFrameSplit;

			// Token: 0x040002A6 RID: 678
			private TArray<byte> Buffer;

			// Token: 0x040002A7 RID: 679
			private readonly int FrameSplitBatch = Math.Max(10, JitProfile.Get_cs_JitProfile_FrameSplitBatch());

			// Token: 0x040002A8 RID: 680
			private string LastTypeName;

			// Token: 0x040002A9 RID: 681
			private Type LastType;
		}
	}
}
