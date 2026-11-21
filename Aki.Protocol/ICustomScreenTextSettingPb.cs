using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AD RID: 1965
	public sealed class ICustomScreenTextSettingPb : IMessage<ICustomScreenTextSettingPb>, IMessage, IEquatable<ICustomScreenTextSettingPb>, IDeepCloneable<ICustomScreenTextSettingPb>, IBufferMessage
	{
		// Token: 0x0600B137 RID: 45367 RVA: 0x001A8C90 File Offset: 0x001A6E90
		[NullableContext(1)]
		public static ICustomScreenTextSettingPb Create()
		{
			return new ICustomScreenTextSettingPb();
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x0600B138 RID: 45368 RVA: 0x001A8C97 File Offset: 0x001A6E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x0600B139 RID: 45369 RVA: 0x001A8C9A File Offset: 0x001A6E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenTextSettingPb.Descriptor;
			}
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x001A8CA1 File Offset: 0x001A6EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTextSettingPb()
		{
		}

		// Token: 0x0600B13B RID: 45371 RVA: 0x001A8CAC File Offset: 0x001A6EAC
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

		// Token: 0x0600B13C RID: 45372 RVA: 0x001A8D00 File Offset: 0x001A6F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTextSettingPb Clone()
		{
			return new ICustomScreenTextSettingPb(this);
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x0600B13D RID: 45373 RVA: 0x001A8D08 File Offset: 0x001A6F08
		// (set) Token: 0x0600B13E RID: 45374 RVA: 0x001A8D20 File Offset: 0x001A6F20
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

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x0600B13F RID: 45375 RVA: 0x001A8D37 File Offset: 0x001A6F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsShowTextInfo
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x001A8D44 File Offset: 0x001A6F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsShowTextInfo()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x0600B141 RID: 45377 RVA: 0x001A8D55 File Offset: 0x001A6F55
		// (set) Token: 0x0600B142 RID: 45378 RVA: 0x001A8D66 File Offset: 0x001A6F66
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

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x0600B143 RID: 45379 RVA: 0x001A8D79 File Offset: 0x001A6F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTidTextContent
		{
			get
			{
				return this.tidTextContent_ != null;
			}
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x001A8D84 File Offset: 0x001A6F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTidTextContent()
		{
			this.tidTextContent_ = null;
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x0600B145 RID: 45381 RVA: 0x001A8D8D File Offset: 0x001A6F8D
		// (set) Token: 0x0600B146 RID: 45382 RVA: 0x001A8D9E File Offset: 0x001A6F9E
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

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x0600B147 RID: 45383 RVA: 0x001A8DB1 File Offset: 0x001A6FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasEdTidTextContent
		{
			get
			{
				return this.edTidTextContent_ != null;
			}
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x001A8DBC File Offset: 0x001A6FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEdTidTextContent()
		{
			this.edTidTextContent_ = null;
		}

		// Token: 0x0600B149 RID: 45385 RVA: 0x001A8DC5 File Offset: 0x001A6FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenTextSettingPb);
		}

		// Token: 0x0600B14A RID: 45386 RVA: 0x001A8DD4 File Offset: 0x001A6FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenTextSettingPb other)
		{
			return other != null && (other == this || (this.IsShowTextInfo == other.IsShowTextInfo && !(this.TidTextContent != other.TidTextContent) && !(this.EdTidTextContent != other.EdTidTextContent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B14B RID: 45387 RVA: 0x001A8E38 File Offset: 0x001A7038
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

		// Token: 0x0600B14C RID: 45388 RVA: 0x001A8EA3 File Offset: 0x001A70A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x001A8EB0 File Offset: 0x001A70B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B14E RID: 45390 RVA: 0x001A8EBC File Offset: 0x001A70BC
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

		// Token: 0x0600B14F RID: 45391 RVA: 0x001A8F30 File Offset: 0x001A7130
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

		// Token: 0x0600B150 RID: 45392 RVA: 0x001A8F94 File Offset: 0x001A7194
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

		// Token: 0x0600B151 RID: 45393 RVA: 0x001A8FF8 File Offset: 0x001A71F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B152 RID: 45394 RVA: 0x001A9004 File Offset: 0x001A7204
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

		// Token: 0x04004FBF RID: 20415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FC0 RID: 20416
		private int _hasBits0;

		// Token: 0x04004FC1 RID: 20417
		public const int IsShowTextInfoFieldNumber = 1;

		// Token: 0x04004FC2 RID: 20418
		private static readonly bool IsShowTextInfoDefaultValue = false;

		// Token: 0x04004FC3 RID: 20419
		private bool isShowTextInfo_;

		// Token: 0x04004FC4 RID: 20420
		public const int TidTextContentFieldNumber = 2;

		// Token: 0x04004FC5 RID: 20421
		private static readonly string TidTextContentDefaultValue = "";

		// Token: 0x04004FC6 RID: 20422
		private string tidTextContent_;

		// Token: 0x04004FC7 RID: 20423
		public const int EdTidTextContentFieldNumber = 3;

		// Token: 0x04004FC8 RID: 20424
		private static readonly string EdTidTextContentDefaultValue = "";

		// Token: 0x04004FC9 RID: 20425
		private string edTidTextContent_;
	}
}
