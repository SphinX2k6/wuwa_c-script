using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C1 RID: 1985
	public sealed class ICustomScreenTextSettingPb : IMessage<ICustomScreenTextSettingPb>, IMessage, IEquatable<ICustomScreenTextSettingPb>, IDeepCloneable<ICustomScreenTextSettingPb>, IBufferMessage
	{
		// Token: 0x0600B28D RID: 45709 RVA: 0x001AB6C0 File Offset: 0x001A98C0
		[NullableContext(1)]
		public static ICustomScreenTextSettingPb Create()
		{
			return new ICustomScreenTextSettingPb();
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600B28E RID: 45710 RVA: 0x001AB6C7 File Offset: 0x001A98C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x0600B28F RID: 45711 RVA: 0x001AB6CA File Offset: 0x001A98CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenTextSettingPb.Descriptor;
			}
		}

		// Token: 0x0600B290 RID: 45712 RVA: 0x001AB6D1 File Offset: 0x001A98D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTextSettingPb()
		{
		}

		// Token: 0x0600B291 RID: 45713 RVA: 0x001AB6DC File Offset: 0x001A98DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTextSettingPb(ICustomScreenTextSettingPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.isShowTextInfo_ = other.isShowTextInfo_;
			this.tidTextContent_ = other.tidTextContent_;
			this.edTidTextContent_ = other.edTidTextContent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B292 RID: 45714 RVA: 0x001AB730 File Offset: 0x001A9930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTextSettingPb Clone()
		{
			return new ICustomScreenTextSettingPb(this);
		}

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x0600B293 RID: 45715 RVA: 0x001AB738 File Offset: 0x001A9938
		// (set) Token: 0x0600B294 RID: 45716 RVA: 0x001AB750 File Offset: 0x001A9950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShowTextInfo
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.isShowTextInfo_;
				}
				return ICustomScreenTextSettingPb.IsShowTextInfoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isShowTextInfo_ = value;
			}
		}

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x0600B295 RID: 45717 RVA: 0x001AB767 File Offset: 0x001A9967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsShowTextInfo
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B296 RID: 45718 RVA: 0x001AB774 File Offset: 0x001A9974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsShowTextInfo()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x0600B297 RID: 45719 RVA: 0x001AB785 File Offset: 0x001A9985
		// (set) Token: 0x0600B298 RID: 45720 RVA: 0x001AB796 File Offset: 0x001A9996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TidTextContent
		{
			get
			{
				return this.tidTextContent_ ?? ICustomScreenTextSettingPb.TidTextContentDefaultValue;
			}
			set
			{
				this.tidTextContent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x0600B299 RID: 45721 RVA: 0x001AB7A9 File Offset: 0x001A99A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTidTextContent
		{
			get
			{
				return this.tidTextContent_ != null;
			}
		}

		// Token: 0x0600B29A RID: 45722 RVA: 0x001AB7B4 File Offset: 0x001A99B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTidTextContent()
		{
			this.tidTextContent_ = null;
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x0600B29B RID: 45723 RVA: 0x001AB7BD File Offset: 0x001A99BD
		// (set) Token: 0x0600B29C RID: 45724 RVA: 0x001AB7CE File Offset: 0x001A99CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string EdTidTextContent
		{
			get
			{
				return this.edTidTextContent_ ?? ICustomScreenTextSettingPb.EdTidTextContentDefaultValue;
			}
			set
			{
				this.edTidTextContent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x0600B29D RID: 45725 RVA: 0x001AB7E1 File Offset: 0x001A99E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasEdTidTextContent
		{
			get
			{
				return this.edTidTextContent_ != null;
			}
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x001AB7EC File Offset: 0x001A99EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEdTidTextContent()
		{
			this.edTidTextContent_ = null;
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x001AB7F5 File Offset: 0x001A99F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenTextSettingPb);
		}

		// Token: 0x0600B2A0 RID: 45728 RVA: 0x001AB804 File Offset: 0x001A9A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenTextSettingPb other)
		{
			return other != null && (other == this || (this.IsShowTextInfo == other.IsShowTextInfo && !(this.TidTextContent != other.TidTextContent) && !(this.EdTidTextContent != other.EdTidTextContent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2A1 RID: 45729 RVA: 0x001AB868 File Offset: 0x001A9A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasIsShowTextInfo)
			{
				num ^= this.IsShowTextInfo.GetHashCode();
			}
			if (this.HasTidTextContent)
			{
				num ^= this.TidTextContent.GetHashCode();
			}
			if (this.HasEdTidTextContent)
			{
				num ^= this.EdTidTextContent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2A2 RID: 45730 RVA: 0x001AB8D3 File Offset: 0x001A9AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B2A3 RID: 45731 RVA: 0x001AB8E0 File Offset: 0x001A9AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2A4 RID: 45732 RVA: 0x001AB8EC File Offset: 0x001A9AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasIsShowTextInfo)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsShowTextInfo);
			}
			if (this.HasTidTextContent)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TidTextContent);
			}
			if (this.HasEdTidTextContent)
			{
				output.WriteRawTag(26);
				output.WriteString(this.EdTidTextContent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2A5 RID: 45733 RVA: 0x001AB960 File Offset: 0x001A9B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasIsShowTextInfo)
			{
				num += 2;
			}
			if (this.HasTidTextContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TidTextContent);
			}
			if (this.HasEdTidTextContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EdTidTextContent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x001AB9C4 File Offset: 0x001A9BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomScreenTextSettingPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasIsShowTextInfo)
			{
				this.IsShowTextInfo = other.IsShowTextInfo;
			}
			if (other.HasTidTextContent)
			{
				this.TidTextContent = other.TidTextContent;
			}
			if (other.HasEdTidTextContent)
			{
				this.EdTidTextContent = other.EdTidTextContent;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x001ABA28 File Offset: 0x001A9C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x001ABA34 File Offset: 0x001A9C34
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EdTidTextContent = input.ReadString();
						}
					}
					else
					{
						this.TidTextContent = input.ReadString();
					}
				}
				else
				{
					this.IsShowTextInfo = input.ReadBool();
				}
			}
		}

		// Token: 0x04004FC6 RID: 20422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FC7 RID: 20423
		private int _hasBits0;

		// Token: 0x04004FC8 RID: 20424
		public const int IsShowTextInfoFieldNumber = 1;

		// Token: 0x04004FC9 RID: 20425
		private static readonly bool IsShowTextInfoDefaultValue = false;

		// Token: 0x04004FCA RID: 20426
		private bool isShowTextInfo_;

		// Token: 0x04004FCB RID: 20427
		public const int TidTextContentFieldNumber = 2;

		// Token: 0x04004FCC RID: 20428
		private static readonly string TidTextContentDefaultValue = "";

		// Token: 0x04004FCD RID: 20429
		private string tidTextContent_;

		// Token: 0x04004FCE RID: 20430
		public const int EdTidTextContentFieldNumber = 3;

		// Token: 0x04004FCF RID: 20431
		private static readonly string EdTidTextContentDefaultValue = "";

		// Token: 0x04004FD0 RID: 20432
		private string edTidTextContent_;
	}
}
