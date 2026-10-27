using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C2 RID: 1986
	public sealed class ICustomScreenTypeBasePb : IMessage<ICustomScreenTypeBasePb>, IMessage, IEquatable<ICustomScreenTypeBasePb>, IDeepCloneable<ICustomScreenTypeBasePb>, IBufferMessage
	{
		// Token: 0x0600B2AA RID: 45738 RVA: 0x001ABABA File Offset: 0x001A9CBA
		[NullableContext(1)]
		public static ICustomScreenTypeBasePb Create()
		{
			return new ICustomScreenTypeBasePb();
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x0600B2AB RID: 45739 RVA: 0x001ABAC1 File Offset: 0x001A9CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x0600B2AC RID: 45740 RVA: 0x001ABAC4 File Offset: 0x001A9CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenTypeBasePb.Descriptor;
			}
		}

		// Token: 0x0600B2AD RID: 45741 RVA: 0x001ABACB File Offset: 0x001A9CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTypeBasePb()
		{
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x001ABAD4 File Offset: 0x001A9CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTypeBasePb(ICustomScreenTypeBasePb other) : this()
		{
			switch (other.ScreenPbCase)
			{
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb:
				this.ICustomScreenSpinePb = other.ICustomScreenSpinePb.Clone();
				break;
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb:
				this.ICustomScreenBackgroundImagePb = other.ICustomScreenBackgroundImagePb.Clone();
				break;
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb:
				this.ICustomScreenLoadingPb = other.ICustomScreenLoadingPb.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x001ABB4C File Offset: 0x001A9D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTypeBasePb Clone()
		{
			return new ICustomScreenTypeBasePb(this);
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x0600B2B0 RID: 45744 RVA: 0x001ABB54 File Offset: 0x001A9D54
		// (set) Token: 0x0600B2B1 RID: 45745 RVA: 0x001ABB6C File Offset: 0x001A9D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenSpinePb ICustomScreenSpinePb
		{
			get
			{
				if (this.screenPbCase_ != ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb)
				{
					return null;
				}
				return (ICustomScreenSpinePb)this.screenPb_;
			}
			set
			{
				this.screenPb_ = value;
				this.screenPbCase_ = ((value == null) ? ICustomScreenTypeBasePb.ScreenPbOneofCase.None : ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb);
			}
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x0600B2B2 RID: 45746 RVA: 0x001ABB82 File Offset: 0x001A9D82
		// (set) Token: 0x0600B2B3 RID: 45747 RVA: 0x001ABB9A File Offset: 0x001A9D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenBackgroundImagePb ICustomScreenBackgroundImagePb
		{
			get
			{
				if (this.screenPbCase_ != ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb)
				{
					return null;
				}
				return (ICustomScreenBackgroundImagePb)this.screenPb_;
			}
			set
			{
				this.screenPb_ = value;
				this.screenPbCase_ = ((value == null) ? ICustomScreenTypeBasePb.ScreenPbOneofCase.None : ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb);
			}
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x0600B2B4 RID: 45748 RVA: 0x001ABBB0 File Offset: 0x001A9DB0
		// (set) Token: 0x0600B2B5 RID: 45749 RVA: 0x001ABBC8 File Offset: 0x001A9DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingPb ICustomScreenLoadingPb
		{
			get
			{
				if (this.screenPbCase_ != ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb)
				{
					return null;
				}
				return (ICustomScreenLoadingPb)this.screenPb_;
			}
			set
			{
				this.screenPb_ = value;
				this.screenPbCase_ = ((value == null) ? ICustomScreenTypeBasePb.ScreenPbOneofCase.None : ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb);
			}
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x0600B2B6 RID: 45750 RVA: 0x001ABBDE File Offset: 0x001A9DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTypeBasePb.ScreenPbOneofCase ScreenPbCase
		{
			get
			{
				return this.screenPbCase_;
			}
		}

		// Token: 0x0600B2B7 RID: 45751 RVA: 0x001ABBE6 File Offset: 0x001A9DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearScreenPb()
		{
			this.screenPbCase_ = ICustomScreenTypeBasePb.ScreenPbOneofCase.None;
			this.screenPb_ = null;
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x001ABBF6 File Offset: 0x001A9DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenTypeBasePb);
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x001ABC04 File Offset: 0x001A9E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenTypeBasePb other)
		{
			return other != null && (other == this || (object.Equals(this.ICustomScreenSpinePb, other.ICustomScreenSpinePb) && object.Equals(this.ICustomScreenBackgroundImagePb, other.ICustomScreenBackgroundImagePb) && object.Equals(this.ICustomScreenLoadingPb, other.ICustomScreenLoadingPb) && this.ScreenPbCase == other.ScreenPbCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x001ABC7C File Offset: 0x001A9E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb)
			{
				num ^= this.ICustomScreenSpinePb.GetHashCode();
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb)
			{
				num ^= this.ICustomScreenBackgroundImagePb.GetHashCode();
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb)
			{
				num ^= this.ICustomScreenLoadingPb.GetHashCode();
			}
			num ^= (int)this.screenPbCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x001ABCF0 File Offset: 0x001A9EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x001ABCFD File Offset: 0x001A9EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x001ABD08 File Offset: 0x001A9F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ICustomScreenSpinePb);
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ICustomScreenBackgroundImagePb);
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ICustomScreenLoadingPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x001ABD80 File Offset: 0x001A9F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomScreenSpinePb);
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomScreenBackgroundImagePb);
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomScreenLoadingPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x001ABDF4 File Offset: 0x001A9FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomScreenTypeBasePb other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.ScreenPbCase)
			{
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb:
				if (this.ICustomScreenSpinePb == null)
				{
					this.ICustomScreenSpinePb = new ICustomScreenSpinePb();
				}
				this.ICustomScreenSpinePb.MergeFrom(other.ICustomScreenSpinePb);
				break;
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb:
				if (this.ICustomScreenBackgroundImagePb == null)
				{
					this.ICustomScreenBackgroundImagePb = new ICustomScreenBackgroundImagePb();
				}
				this.ICustomScreenBackgroundImagePb.MergeFrom(other.ICustomScreenBackgroundImagePb);
				break;
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb:
				if (this.ICustomScreenLoadingPb == null)
				{
					this.ICustomScreenLoadingPb = new ICustomScreenLoadingPb();
				}
				this.ICustomScreenLoadingPb.MergeFrom(other.ICustomScreenLoadingPb);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x001ABEA9 File Offset: 0x001AA0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2C1 RID: 45761 RVA: 0x001ABEB4 File Offset: 0x001AA0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 10U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							ICustomScreenLoadingPb customScreenLoadingPb = new ICustomScreenLoadingPb();
							if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb)
							{
								customScreenLoadingPb.MergeFrom(this.ICustomScreenLoadingPb);
							}
							input.ReadMessage(customScreenLoadingPb);
							this.ICustomScreenLoadingPb = customScreenLoadingPb;
						}
					}
					else
					{
						ICustomScreenBackgroundImagePb customScreenBackgroundImagePb = new ICustomScreenBackgroundImagePb();
						if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb)
						{
							customScreenBackgroundImagePb.MergeFrom(this.ICustomScreenBackgroundImagePb);
						}
						input.ReadMessage(customScreenBackgroundImagePb);
						this.ICustomScreenBackgroundImagePb = customScreenBackgroundImagePb;
					}
				}
				else
				{
					ICustomScreenSpinePb customScreenSpinePb = new ICustomScreenSpinePb();
					if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb)
					{
						customScreenSpinePb.MergeFrom(this.ICustomScreenSpinePb);
					}
					input.ReadMessage(customScreenSpinePb);
					this.ICustomScreenSpinePb = customScreenSpinePb;
				}
			}
		}

		// Token: 0x04004FD1 RID: 20433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FD2 RID: 20434
		public const int ICustomScreenSpinePbFieldNumber = 1;

		// Token: 0x04004FD3 RID: 20435
		public const int ICustomScreenBackgroundImagePbFieldNumber = 2;

		// Token: 0x04004FD4 RID: 20436
		public const int ICustomScreenLoadingPbFieldNumber = 3;

		// Token: 0x04004FD5 RID: 20437
		private object screenPb_;

		// Token: 0x04004FD6 RID: 20438
		private ICustomScreenTypeBasePb.ScreenPbOneofCase screenPbCase_;

		// Token: 0x020017F3 RID: 6131
		public enum ScreenPbOneofCase
		{
			// Token: 0x0400C797 RID: 51095
			None,
			// Token: 0x0400C798 RID: 51096
			ICustomScreenSpinePb,
			// Token: 0x0400C799 RID: 51097
			ICustomScreenBackgroundImagePb,
			// Token: 0x0400C79A RID: 51098
			ICustomScreenLoadingPb
		}
	}
}
