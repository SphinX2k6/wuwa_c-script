using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000952 RID: 2386
	public sealed class LordGymPassRecord : IMessage<LordGymPassRecord>, IMessage, IEquatable<LordGymPassRecord>, IDeepCloneable<LordGymPassRecord>, IBufferMessage
	{
		// Token: 0x0600D29D RID: 53917 RVA: 0x001F106D File Offset: 0x001EF26D
		[NullableContext(1)]
		public static LordGymPassRecord Create()
		{
			return new LordGymPassRecord();
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x0600D29E RID: 53918 RVA: 0x001F1074 File Offset: 0x001EF274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LordGymPassRecord> Parser
		{
			get
			{
				return LordGymPassRecord._parser;
			}
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x0600D29F RID: 53919 RVA: 0x001F107B File Offset: 0x001EF27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x0600D2A0 RID: 53920 RVA: 0x001F107E File Offset: 0x001EF27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymPassRecord.Descriptor;
			}
		}

		// Token: 0x0600D2A1 RID: 53921 RVA: 0x001F1085 File Offset: 0x001EF285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymPassRecord()
		{
		}

		// Token: 0x0600D2A2 RID: 53922 RVA: 0x001F1098 File Offset: 0x001EF298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymPassRecord(LordGymPassRecord other) : this()
		{
			this.loadGymId_ = other.loadGymId_;
			this.passTime_ = other.passTime_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2A3 RID: 53923 RVA: 0x001F10E5 File Offset: 0x001EF2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymPassRecord Clone()
		{
			return new LordGymPassRecord(this);
		}

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x0600D2A4 RID: 53924 RVA: 0x001F10ED File Offset: 0x001EF2ED
		// (set) Token: 0x0600D2A5 RID: 53925 RVA: 0x001F10F5 File Offset: 0x001EF2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoadGymId
		{
			get
			{
				return this.loadGymId_;
			}
			set
			{
				this.loadGymId_ = value;
			}
		}

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x0600D2A6 RID: 53926 RVA: 0x001F10FE File Offset: 0x001EF2FE
		// (set) Token: 0x0600D2A7 RID: 53927 RVA: 0x001F1106 File Offset: 0x001EF306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x0600D2A8 RID: 53928 RVA: 0x001F110F File Offset: 0x001EF30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleBrief> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x0600D2A9 RID: 53929 RVA: 0x001F1117 File Offset: 0x001EF317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymPassRecord);
		}

		// Token: 0x0600D2AA RID: 53930 RVA: 0x001F1128 File Offset: 0x001EF328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymPassRecord other)
		{
			return other != null && (other == this || (this.LoadGymId == other.LoadGymId && this.PassTime == other.PassTime && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2AB RID: 53931 RVA: 0x001F1188 File Offset: 0x001EF388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadGymId != 0)
			{
				num ^= this.LoadGymId.GetHashCode();
			}
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D2AC RID: 53932 RVA: 0x001F11EE File Offset: 0x001EF3EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D2AD RID: 53933 RVA: 0x001F11FB File Offset: 0x001EF3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2AE RID: 53934 RVA: 0x001F1204 File Offset: 0x001EF404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoadGymId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LoadGymId);
			}
			if (this.PassTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PassTime);
			}
			this.roleIds_.WriteTo(ref output, LordGymPassRecord._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2AF RID: 53935 RVA: 0x001F1270 File Offset: 0x001EF470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadGymId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoadGymId);
			}
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			num += this.roleIds_.CalculateSize(LordGymPassRecord._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D2B0 RID: 53936 RVA: 0x001F12DC File Offset: 0x001EF4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymPassRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadGymId != 0)
			{
				this.LoadGymId = other.LoadGymId;
			}
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			this.roleIds_.Add(other.roleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D2B1 RID: 53937 RVA: 0x001F133D File Offset: 0x001EF53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2B2 RID: 53938 RVA: 0x001F1348 File Offset: 0x001EF548
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.roleIds_.AddEntriesFrom(ref input, LordGymPassRecord._repeated_roleIds_codec);
						}
					}
					else
					{
						this.PassTime = input.ReadInt32();
					}
				}
				else
				{
					this.LoadGymId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005901 RID: 22785
		private static readonly MessageParser<LordGymPassRecord> _parser = new MessageParser<LordGymPassRecord>(() => new LordGymPassRecord());

		// Token: 0x04005902 RID: 22786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005903 RID: 22787
		public const int LoadGymIdFieldNumber = 1;

		// Token: 0x04005904 RID: 22788
		private int loadGymId_;

		// Token: 0x04005905 RID: 22789
		public const int PassTimeFieldNumber = 2;

		// Token: 0x04005906 RID: 22790
		private int passTime_;

		// Token: 0x04005907 RID: 22791
		public const int RoleIdsFieldNumber = 3;

		// Token: 0x04005908 RID: 22792
		private static readonly FieldCodec<RoleBrief> _repeated_roleIds_codec = FieldCodec.ForMessage<RoleBrief>(26U, RoleBrief.Parser);

		// Token: 0x04005909 RID: 22793
		private readonly RepeatedField<RoleBrief> roleIds_ = new RepeatedField<RoleBrief>();
	}
}
