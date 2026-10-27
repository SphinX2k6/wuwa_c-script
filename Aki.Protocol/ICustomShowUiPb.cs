using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C3 RID: 1987
	public sealed class ICustomShowUiPb : IMessage<ICustomShowUiPb>, IMessage, IEquatable<ICustomShowUiPb>, IDeepCloneable<ICustomShowUiPb>, IBufferMessage
	{
		// Token: 0x0600B2C2 RID: 45762 RVA: 0x001ABF7C File Offset: 0x001AA17C
		[NullableContext(1)]
		public static ICustomShowUiPb Create()
		{
			return new ICustomShowUiPb();
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x0600B2C3 RID: 45763 RVA: 0x001ABF83 File Offset: 0x001AA183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x0600B2C4 RID: 45764 RVA: 0x001ABF86 File Offset: 0x001AA186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomShowUiPb.Descriptor;
			}
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x001ABF8D File Offset: 0x001AA18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomShowUiPb()
		{
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x001ABF98 File Offset: 0x001AA198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomShowUiPb(ICustomShowUiPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.iCustomScreenTextSettingPb_ = ((other.iCustomScreenTextSettingPb_ != null) ? other.iCustomScreenTextSettingPb_.Clone() : null);
			this.isHideCircle_ = other.isHideCircle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x001ABFF0 File Offset: 0x001AA1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomShowUiPb Clone()
		{
			return new ICustomShowUiPb(this);
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x0600B2C8 RID: 45768 RVA: 0x001ABFF8 File Offset: 0x001AA1F8
		// (set) Token: 0x0600B2C9 RID: 45769 RVA: 0x001AC000 File Offset: 0x001AA200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTextSettingPb ICustomScreenTextSettingPb
		{
			get
			{
				return this.iCustomScreenTextSettingPb_;
			}
			set
			{
				this.iCustomScreenTextSettingPb_ = value;
			}
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x0600B2CA RID: 45770 RVA: 0x001AC009 File Offset: 0x001AA209
		// (set) Token: 0x0600B2CB RID: 45771 RVA: 0x001AC021 File Offset: 0x001AA221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsHideCircle
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.isHideCircle_;
				}
				return ICustomShowUiPb.IsHideCircleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isHideCircle_ = value;
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x0600B2CC RID: 45772 RVA: 0x001AC038 File Offset: 0x001AA238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsHideCircle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B2CD RID: 45773 RVA: 0x001AC045 File Offset: 0x001AA245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsHideCircle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600B2CE RID: 45774 RVA: 0x001AC056 File Offset: 0x001AA256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomShowUiPb);
		}

		// Token: 0x0600B2CF RID: 45775 RVA: 0x001AC064 File Offset: 0x001AA264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomShowUiPb other)
		{
			return other != null && (other == this || (object.Equals(this.ICustomScreenTextSettingPb, other.ICustomScreenTextSettingPb) && this.IsHideCircle == other.IsHideCircle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2D0 RID: 45776 RVA: 0x001AC0B4 File Offset: 0x001AA2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.iCustomScreenTextSettingPb_ != null)
			{
				num ^= this.ICustomScreenTextSettingPb.GetHashCode();
			}
			if (this.HasIsHideCircle)
			{
				num ^= this.IsHideCircle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2D1 RID: 45777 RVA: 0x001AC109 File Offset: 0x001AA309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B2D2 RID: 45778 RVA: 0x001AC116 File Offset: 0x001AA316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2D3 RID: 45779 RVA: 0x001AC120 File Offset: 0x001AA320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iCustomScreenTextSettingPb_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ICustomScreenTextSettingPb);
			}
			if (this.HasIsHideCircle)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsHideCircle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2D4 RID: 45780 RVA: 0x001AC17C File Offset: 0x001AA37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.iCustomScreenTextSettingPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomScreenTextSettingPb);
			}
			if (this.HasIsHideCircle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2D5 RID: 45781 RVA: 0x001AC1C8 File Offset: 0x001AA3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomShowUiPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.iCustomScreenTextSettingPb_ != null)
			{
				if (this.iCustomScreenTextSettingPb_ == null)
				{
					this.ICustomScreenTextSettingPb = new ICustomScreenTextSettingPb();
				}
				this.ICustomScreenTextSettingPb.MergeFrom(other.ICustomScreenTextSettingPb);
			}
			if (other.HasIsHideCircle)
			{
				this.IsHideCircle = other.IsHideCircle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2D6 RID: 45782 RVA: 0x001AC230 File Offset: 0x001AA430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2D7 RID: 45783 RVA: 0x001AC23C File Offset: 0x001AA43C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsHideCircle = input.ReadBool();
					}
				}
				else
				{
					if (this.iCustomScreenTextSettingPb_ == null)
					{
						this.ICustomScreenTextSettingPb = new ICustomScreenTextSettingPb();
					}
					input.ReadMessage(this.ICustomScreenTextSettingPb);
				}
			}
		}

		// Token: 0x04004FD7 RID: 20439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FD8 RID: 20440
		private int _hasBits0;

		// Token: 0x04004FD9 RID: 20441
		public const int ICustomScreenTextSettingPbFieldNumber = 1;

		// Token: 0x04004FDA RID: 20442
		private ICustomScreenTextSettingPb iCustomScreenTextSettingPb_;

		// Token: 0x04004FDB RID: 20443
		public const int IsHideCircleFieldNumber = 2;

		// Token: 0x04004FDC RID: 20444
		private static readonly bool IsHideCircleDefaultValue;

		// Token: 0x04004FDD RID: 20445
		private bool isHideCircle_;
	}
}
