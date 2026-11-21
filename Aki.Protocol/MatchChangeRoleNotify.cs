using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A3 RID: 2467
	[NetMessage(EMessageId.MatchChangeRoleNotify)]
	public sealed class MatchChangeRoleNotify : IMessage<MatchChangeRoleNotify>, IMessage, IEquatable<MatchChangeRoleNotify>, IDeepCloneable<MatchChangeRoleNotify>, IBufferMessage
	{
		// Token: 0x0600D8E3 RID: 55523 RVA: 0x001FE03A File Offset: 0x001FC23A
		[NullableContext(1)]
		public static MatchChangeRoleNotify Create()
		{
			return new MatchChangeRoleNotify();
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x0600D8E4 RID: 55524 RVA: 0x001FE041 File Offset: 0x001FC241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x0600D8E5 RID: 55525 RVA: 0x001FE044 File Offset: 0x001FC244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeRoleNotify.Descriptor;
			}
		}

		// Token: 0x0600D8E6 RID: 55526 RVA: 0x001FE04B File Offset: 0x001FC24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleNotify()
		{
		}

		// Token: 0x0600D8E7 RID: 55527 RVA: 0x001FE05E File Offset: 0x001FC25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleNotify(MatchChangeRoleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.roleInfo_ = other.roleInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8E8 RID: 55528 RVA: 0x001FE094 File Offset: 0x001FC294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleNotify Clone()
		{
			return new MatchChangeRoleNotify(this);
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x0600D8E9 RID: 55529 RVA: 0x001FE09C File Offset: 0x001FC29C
		// (set) Token: 0x0600D8EA RID: 55530 RVA: 0x001FE0A4 File Offset: 0x001FC2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x0600D8EB RID: 55531 RVA: 0x001FE0AD File Offset: 0x001FC2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MatchRoleInfo> RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
		}

		// Token: 0x0600D8EC RID: 55532 RVA: 0x001FE0B5 File Offset: 0x001FC2B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeRoleNotify);
		}

		// Token: 0x0600D8ED RID: 55533 RVA: 0x001FE0C4 File Offset: 0x001FC2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeRoleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.roleInfo_.Equals(other.roleInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8EE RID: 55534 RVA: 0x001FE114 File Offset: 0x001FC314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.roleInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D8EF RID: 55535 RVA: 0x001FE161 File Offset: 0x001FC361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D8F0 RID: 55536 RVA: 0x001FE16E File Offset: 0x001FC36E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8F1 RID: 55537 RVA: 0x001FE178 File Offset: 0x001FC378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleInfo_.WriteTo(ref output, MatchChangeRoleNotify._repeated_roleInfo_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D8F2 RID: 55538 RVA: 0x001FE1C8 File Offset: 0x001FC3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.roleInfo_.CalculateSize(MatchChangeRoleNotify._repeated_roleInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D8F3 RID: 55539 RVA: 0x001FE21C File Offset: 0x001FC41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangeRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.roleInfo_.Add(other.roleInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D8F4 RID: 55540 RVA: 0x001FE269 File Offset: 0x001FC469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8F5 RID: 55541 RVA: 0x001FE274 File Offset: 0x001FC474
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
				if (num != 26U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.roleInfo_.AddEntriesFrom(ref input, MatchChangeRoleNotify._repeated_roleInfo_codec);
				}
			}
		}

		// Token: 0x04005A9D RID: 23197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A9E RID: 23198
		public const int PlayerIdFieldNumber = 15;

		// Token: 0x04005A9F RID: 23199
		private int playerId_;

		// Token: 0x04005AA0 RID: 23200
		public const int RoleInfoFieldNumber = 3;

		// Token: 0x04005AA1 RID: 23201
		private static readonly FieldCodec<MatchRoleInfo> _repeated_roleInfo_codec = FieldCodec.ForMessage<MatchRoleInfo>(26U, MatchRoleInfo.Parser);

		// Token: 0x04005AA2 RID: 23202
		private readonly RepeatedField<MatchRoleInfo> roleInfo_ = new RepeatedField<MatchRoleInfo>();
	}
}
