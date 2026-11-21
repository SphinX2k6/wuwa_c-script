using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F9 RID: 2553
	[NetMessage(EMessageId.MontagePlayResponse)]
	public sealed class MontagePlayResponse : IMessage<MontagePlayResponse>, IMessage, IEquatable<MontagePlayResponse>, IDeepCloneable<MontagePlayResponse>, IBufferMessage
	{
		// Token: 0x0600DFC0 RID: 57280 RVA: 0x0020CE05 File Offset: 0x0020B005
		[NullableContext(1)]
		public static MontagePlayResponse Create()
		{
			return new MontagePlayResponse();
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x0600DFC1 RID: 57281 RVA: 0x0020CE0C File Offset: 0x0020B00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x0600DFC2 RID: 57282 RVA: 0x0020CE0F File Offset: 0x0020B00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MontagePlayResponse.Descriptor;
			}
		}

		// Token: 0x0600DFC3 RID: 57283 RVA: 0x0020CE16 File Offset: 0x0020B016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayResponse()
		{
		}

		// Token: 0x0600DFC4 RID: 57284 RVA: 0x0020CE20 File Offset: 0x0020B020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayResponse(MontagePlayResponse other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFC5 RID: 57285 RVA: 0x0020CE78 File Offset: 0x0020B078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayResponse Clone()
		{
			return new MontagePlayResponse(this);
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x0600DFC6 RID: 57286 RVA: 0x0020CE80 File Offset: 0x0020B080
		// (set) Token: 0x0600DFC7 RID: 57287 RVA: 0x0020CE88 File Offset: 0x0020B088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x0600DFC8 RID: 57288 RVA: 0x0020CE91 File Offset: 0x0020B091
		// (set) Token: 0x0600DFC9 RID: 57289 RVA: 0x0020CE99 File Offset: 0x0020B099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontageIndex
		{
			get
			{
				return this.montageIndex_;
			}
			set
			{
				this.montageIndex_ = value;
			}
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x0600DFCA RID: 57290 RVA: 0x0020CEA2 File Offset: 0x0020B0A2
		// (set) Token: 0x0600DFCB RID: 57291 RVA: 0x0020CEAA File Offset: 0x0020B0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x0600DFCC RID: 57292 RVA: 0x0020CEB3 File Offset: 0x0020B0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MontagePlayResponse);
		}

		// Token: 0x0600DFCD RID: 57293 RVA: 0x0020CEC4 File Offset: 0x0020B0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MontagePlayResponse other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFCE RID: 57294 RVA: 0x0020CF24 File Offset: 0x0020B124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.MontageIndex != 0)
			{
				num ^= this.MontageIndex.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DFCF RID: 57295 RVA: 0x0020CF92 File Offset: 0x0020B192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DFD0 RID: 57296 RVA: 0x0020CF9F File Offset: 0x0020B19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFD1 RID: 57297 RVA: 0x0020CFA8 File Offset: 0x0020B1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Error);
			}
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MontageIndex);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFD2 RID: 57298 RVA: 0x0020D020 File Offset: 0x0020B220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.MontageIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageIndex);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DFD3 RID: 57299 RVA: 0x0020D090 File Offset: 0x0020B290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MontagePlayResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.MontageIndex != 0)
			{
				this.MontageIndex = other.MontageIndex;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DFD4 RID: 57300 RVA: 0x0020D10C File Offset: 0x0020B30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFD5 RID: 57301 RVA: 0x0020D118 File Offset: 0x0020B318
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
				if (num != 34U)
				{
					if (num != 64U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SkillId = input.ReadInt64();
						}
					}
					else
					{
						this.MontageIndex = input.ReadInt32();
					}
				}
				else
				{
					if (this.error_ == null)
					{
						this.Error = new DErrorResult();
					}
					input.ReadMessage(this.Error);
				}
			}
		}

		// Token: 0x04005C85 RID: 23685
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C86 RID: 23686
		public const int SkillIdFieldNumber = 11;

		// Token: 0x04005C87 RID: 23687
		private long skillId_;

		// Token: 0x04005C88 RID: 23688
		public const int MontageIndexFieldNumber = 8;

		// Token: 0x04005C89 RID: 23689
		private int montageIndex_;

		// Token: 0x04005C8A RID: 23690
		public const int ErrorFieldNumber = 4;

		// Token: 0x04005C8B RID: 23691
		private DErrorResult error_;
	}
}
