using System;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x02000202 RID: 514
	public static class EDownloadStateExtensions
	{
		// Token: 0x06000D36 RID: 3382 RVA: 0x0005000C File Offset: 0x0004E20C
		public static string ToEnumString(this EDownloadState value)
		{
			string result;
			switch (value)
			{
			case EDownloadState.None:
				result = "None";
				break;
			case EDownloadState.HttpError:
				result = "HttpError";
				break;
			case EDownloadState.FileRenameError:
				result = "FileRenameError";
				break;
			case EDownloadState.ValidateError:
				result = "ValidateError";
				break;
			case EDownloadState.OpenToWriteError:
				result = "OpenToWriteError";
				break;
			case EDownloadState.NotEnoughSpace:
				result = "NotEnoughSpace";
				break;
			case EDownloadState.DownloadCanceled:
				result = "DownloadCanceled";
				break;
			case EDownloadState.Success:
				result = "Success";
				break;
			case EDownloadState.ChangeToCell:
				result = "ChangeToCell";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0005009C File Offset: 0x0004E29C
		public static EDownloadState FromString(string name)
		{
			EDownloadState result;
			if (!EDownloadStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDownloadState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000500C8 File Offset: 0x0004E2C8
		public static bool TryFromString(string name, out EDownloadState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDownloadState.None;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 4:
					if (name == "None")
					{
						value = EDownloadState.None;
						return true;
					}
					break;
				case 7:
					if (name == "Success")
					{
						value = EDownloadState.Success;
						return true;
					}
					break;
				case 9:
					if (name == "HttpError")
					{
						value = EDownloadState.HttpError;
						return true;
					}
					break;
				case 12:
					if (name == "ChangeToCell")
					{
						value = EDownloadState.ChangeToCell;
						return true;
					}
					break;
				case 13:
					if (name == "ValidateError")
					{
						value = EDownloadState.ValidateError;
						return true;
					}
					break;
				case 14:
					if (name == "NotEnoughSpace")
					{
						value = EDownloadState.NotEnoughSpace;
						return true;
					}
					break;
				case 15:
					if (name == "FileRenameError")
					{
						value = EDownloadState.FileRenameError;
						return true;
					}
					break;
				case 16:
				{
					char c = name[0];
					if (c != 'D')
					{
						if (c == 'O')
						{
							if (name == "OpenToWriteError")
							{
								value = EDownloadState.OpenToWriteError;
								return true;
							}
						}
					}
					else if (name == "DownloadCanceled")
					{
						value = EDownloadState.DownloadCanceled;
						return true;
					}
					break;
				}
				}
			}
			value = EDownloadState.None;
			return false;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0005020C File Offset: 0x0004E40C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"None",
				"HttpError",
				"FileRenameError",
				"ValidateError",
				"OpenToWriteError",
				"NotEnoughSpace",
				"DownloadCanceled",
				"Success",
				"ChangeToCell"
			};
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00050268 File Offset: 0x0004E468
		public static EDownloadState[] GetValues()
		{
			return new EDownloadState[]
			{
				EDownloadState.None,
				EDownloadState.HttpError,
				EDownloadState.FileRenameError,
				EDownloadState.ValidateError,
				EDownloadState.OpenToWriteError,
				EDownloadState.NotEnoughSpace,
				EDownloadState.DownloadCanceled,
				EDownloadState.Success,
				EDownloadState.ChangeToCell
			};
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0005027C File Offset: 0x0004E47C
		public static string[] GetNames()
		{
			return new string[]
			{
				"None",
				"HttpError",
				"FileRenameError",
				"ValidateError",
				"OpenToWriteError",
				"NotEnoughSpace",
				"DownloadCanceled",
				"Success",
				"ChangeToCell"
			};
		}
	}
}
