using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022A RID: 554
	[NullableContext(1)]
	[Nullable(0)]
	public class DestFileInfo : LocalFileInfo
	{
		// Token: 0x06000E1C RID: 3612 RVA: 0x00054EB6 File Offset: 0x000530B6
		public DestFileInfo(string keyName, string filePath, long expectSize, string remoteRoute, string expectHash) : base(keyName, filePath, expectSize)
		{
			this.RemoteRoute = remoteRoute;
			this.ExpectHash = expectHash;
			if (this.ExpectSize <= 0L)
			{
				throw new Exception("the new resource file size is unknown! file:{this.KeyName}");
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00054EE8 File Offset: 0x000530E8
		[NullableContext(0)]
		private ValueTuple<long, long> GetBothSize()
		{
			long num = UKuroLauncherLibrary.GetFileSize(this.FilePath);
			long num2 = -1L;
			string text = this.FilePath + ".download";
			if (num >= 0L)
			{
				if (UBlueprintPathsLibrary.FileExists(text))
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "delete local tmp file. both exist it and tmp.";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("file", this.KeyName);
					instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					UKuroLauncherLibrary.DeleteFile(text);
				}
				if (num > this.ExpectSize)
				{
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "delete local file. size > expect";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("file", this.KeyName);
					instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					UKuroLauncherLibrary.DeleteFile(this.FilePath);
					num = -1L;
				}
			}
			else
			{
				num2 = UKuroLauncherLibrary.GetFileSize(text);
				if (num2 > this.ExpectSize)
				{
					LauncherLog instance3 = LauncherLog.Instance;
					string message3 = "delete local tmp file. size > expect";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("path", text);
					instance3.Info(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					UKuroLauncherLibrary.DeleteFile(text);
					num2 = -1L;
				}
			}
			return new ValueTuple<long, long>(num, num2);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00054FD8 File Offset: 0x000531D8
		public override long GetSelfSize()
		{
			long item = this.GetBothSize().Item1;
			if (item < 0L)
			{
				return 0L;
			}
			return item;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00054FFC File Offset: 0x000531FC
		public override long GetLocalSize()
		{
			ValueTuple<long, long> bothSize = this.GetBothSize();
			long item = bothSize.Item1;
			long item2 = bothSize.Item2;
			if (item >= 0L)
			{
				return item;
			}
			if (item2 < 0L)
			{
				return 0L;
			}
			return item2;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0005502C File Offset: 0x0005322C
		public unsafe override bool IsCompleteFile()
		{
			long item = this.GetBothSize().Item1;
			bool flag = this.ExpectSize == item;
			LauncherLog instance = LauncherLog.Instance;
			string message = "is complete file?";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("complete", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("file", this.KeyName);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return flag;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000550A9 File Offset: 0x000532A9
		public override void DeleteAll()
		{
			LauncherFileLib.RemoveDownloadFile(this.FilePath);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000550B6 File Offset: 0x000532B6
		public override string GetHash()
		{
			return this.ExpectHash;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000550BE File Offset: 0x000532BE
		public override RequireFileInfo GetRequireInfo()
		{
			return new RequireFileInfo(this.RemoteRoute, this.FilePath, this.ExpectSize, this.ExpectHash);
		}

		// Token: 0x040008EB RID: 2283
		public readonly string RemoteRoute;

		// Token: 0x040008EC RID: 2284
		public readonly string ExpectHash;
	}
}
