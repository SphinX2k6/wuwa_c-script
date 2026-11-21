using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F9 RID: 1529
	public sealed class FlySkinInfo : IMessage<FlySkinInfo>, IMessage, IEquatable<FlySkinInfo>, IDeepCloneable<FlySkinInfo>, IBufferMessage
	{
		// Token: 0x06008DD8 RID: 36312 RVA: 0x00158598 File Offset: 0x00156798
		[NullableContext(1)]
		public static FlySkinInfo Create()
		{
			return new FlySkinInfo();
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06008DD9 RID: 36313 RVA: 0x0015859F File Offset: 0x0015679F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlySkinInfo> Parser
		{
			get
			{
				return FlySkinInfo._parser;
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06008DDA RID: 36314 RVA: 0x001585A6 File Offset: 0x001567A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06008DDB RID: 36315 RVA: 0x001585A9 File Offset: 0x001567A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinInfo.Descriptor;
			}
		}

		// Token: 0x06008DDC RID: 36316 RVA: 0x001585B0 File Offset: 0x001567B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinInfo()
		{
		}

		// Token: 0x06008DDD RID: 36317 RVA: 0x001585B8 File Offset: 0x001567B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinInfo(FlySkinInfo other) : this()
		{
			this.skinId_ = other.skinId_;
			this.skinType_ = other.skinType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DDE RID: 36318 RVA: 0x001585E9 File Offset: 0x001567E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinInfo Clone()
		{
			return new FlySkinInfo(this);
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06008DDF RID: 36319 RVA: 0x001585F1 File Offset: 0x001567F1
		// (set) Token: 0x06008DE0 RID: 36320 RVA: 0x001585F9 File Offset: 0x001567F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06008DE1 RID: 36321 RVA: 0x00158602 File Offset: 0x00156802
		// (set) Token: 0x06008DE2 RID: 36322 RVA: 0x0015860A File Offset: 0x0015680A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinType
		{
			get
			{
				return this.skinType_;
			}
			set
			{
				this.skinType_ = value;
			}
		}

		// Token: 0x06008DE3 RID: 36323 RVA: 0x00158613 File Offset: 0x00156813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinInfo);
		}

		// Token: 0x06008DE4 RID: 36324 RVA: 0x00158621 File Offset: 0x00156821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinInfo other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && this.SkinType == other.SkinType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DE5 RID: 36325 RVA: 0x00158660 File Offset: 0x00156860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this.SkinType != 0)
			{
				num ^= this.SkinType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DE6 RID: 36326 RVA: 0x001586B8 File Offset: 0x001568B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008DE7 RID: 36327 RVA: 0x001586C5 File Offset: 0x001568C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x001586D0 File Offset: 0x001568D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkinId);
			}
			if (this.SkinType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkinType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DE9 RID: 36329 RVA: 0x00158728 File Offset: 0x00156928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this.SkinType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DEA RID: 36330 RVA: 0x00158780 File Offset: 0x00156980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			if (other.SkinType != 0)
			{
				this.SkinType = other.SkinType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x001587D0 File Offset: 0x001569D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x001587DC File Offset: 0x001569DC
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkinType = input.ReadInt32();
					}
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400458F RID: 17807
		private static readonly MessageParser<FlySkinInfo> _parser = new MessageParser<FlySkinInfo>(() => new FlySkinInfo());

		// Token: 0x04004590 RID: 17808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004591 RID: 17809
		public const int SkinIdFieldNumber = 1;

		// Token: 0x04004592 RID: 17810
		private int skinId_;

		// Token: 0x04004593 RID: 17811
		public const int SkinTypeFieldNumber = 2;

		// Token: 0x04004594 RID: 17812
		private int skinType_;
	}
}
