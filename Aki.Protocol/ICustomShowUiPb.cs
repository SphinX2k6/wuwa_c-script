using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AF RID: 1967
	public sealed class ICustomShowUiPb : IMessage<ICustomShowUiPb>, IMessage, IEquatable<ICustomShowUiPb>, IDeepCloneable<ICustomShowUiPb>, IBufferMessage
	{
		// Token: 0x0600B16C RID: 45420 RVA: 0x001A954C File Offset: 0x001A774C
		[NullableContext(1)]
		public static ICustomShowUiPb Create()
		{
			return new ICustomShowUiPb();
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x0600B16D RID: 45421 RVA: 0x001A9553 File Offset: 0x001A7753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x0600B16E RID: 45422 RVA: 0x001A9556 File Offset: 0x001A7756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomShowUiPb.Descriptor;
			}
		}

		// Token: 0x0600B16F RID: 45423 RVA: 0x001A955D File Offset: 0x001A775D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomShowUiPb()
		{
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x001A9568 File Offset: 0x001A7768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomShowUiPb(ICustomShowUiPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.iCustomScreenTextSettingPb_ = ((other.iCustomScreenTextSettingPb_ != null) ? other.iCustomScreenTextSettingPb_.Clone() : null);
			this.isHideCircle_ = other.isHideCircle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x001A95C0 File Offset: 0x001A77C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomShowUiPb Clone()
		{
			return new ICustomShowUiPb(this);
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x0600B172 RID: 45426 RVA: 0x001A95C8 File Offset: 0x001A77C8
		// (set) Token: 0x0600B173 RID: 45427 RVA: 0x001A95D0 File Offset: 0x001A77D0
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

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x0600B174 RID: 45428 RVA: 0x001A95D9 File Offset: 0x001A77D9
		// (set) Token: 0x0600B175 RID: 45429 RVA: 0x001A95F1 File Offset: 0x001A77F1
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

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x0600B176 RID: 45430 RVA: 0x001A9608 File Offset: 0x001A7808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsHideCircle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B177 RID: 45431 RVA: 0x001A9615 File Offset: 0x001A7815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsHideCircle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x001A9626 File Offset: 0x001A7826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomShowUiPb);
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x001A9634 File Offset: 0x001A7834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomShowUiPb other)
		{
			return other != null && (other == this || (object.Equals(this.ICustomScreenTextSettingPb, other.ICustomScreenTextSettingPb) && this.IsHideCircle == other.IsHideCircle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x001A9684 File Offset: 0x001A7884
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

		// Token: 0x0600B17B RID: 45435 RVA: 0x001A96D9 File Offset: 0x001A78D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B17C RID: 45436 RVA: 0x001A96E6 File Offset: 0x001A78E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B17D RID: 45437 RVA: 0x001A96F0 File Offset: 0x001A78F0
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

		// Token: 0x0600B17E RID: 45438 RVA: 0x001A974C File Offset: 0x001A794C
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

		// Token: 0x0600B17F RID: 45439 RVA: 0x001A9798 File Offset: 0x001A7998
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

		// Token: 0x0600B180 RID: 45440 RVA: 0x001A9800 File Offset: 0x001A7A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B181 RID: 45441 RVA: 0x001A980C File Offset: 0x001A7A0C
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

		// Token: 0x04004FD0 RID: 20432
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FD1 RID: 20433
		private int _hasBits0;

		// Token: 0x04004FD2 RID: 20434
		public const int ICustomScreenTextSettingPbFieldNumber = 1;

		// Token: 0x04004FD3 RID: 20435
		private ICustomScreenTextSettingPb iCustomScreenTextSettingPb_;

		// Token: 0x04004FD4 RID: 20436
		public const int IsHideCircleFieldNumber = 2;

		// Token: 0x04004FD5 RID: 20437
		private static readonly bool IsHideCircleDefaultValue;

		// Token: 0x04004FD6 RID: 20438
		private bool isHideCircle_;
	}
}
