using System;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x02000207 RID: 519
	public static class EDownloadStateExtensions
	{
		// Token: 0x06000D77 RID: 3447 RVA: 0x00052AF8 File Offset: 0x00050CF8
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

		// Token: 0x06000D78 RID: 3448 RVA: 0x00052B88 File Offset: 0x00050D88
		public static EDownloadState FromString(string name)
		{
			EDownloadState result;
			if (!EDownloadStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDownloadState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00052BB4 File Offset: 0x00050DB4
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

		// Token: 0x06000D7A RID: 3450 RVA: 0x00052CF8 File Offset: 0x00050EF8
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

		// Token: 0x06000D7B RID: 3451 RVA: 0x00052D54 File Offset: 0x00050F54
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

		// Token: 0x06000D7C RID: 3452 RVA: 0x00052D68 File Offset: 0x00050F68
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
