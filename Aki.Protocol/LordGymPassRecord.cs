using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000963 RID: 2403
	public sealed class LordGymPassRecord : IMessage<LordGymPassRecord>, IMessage, IEquatable<LordGymPassRecord>, IDeepCloneable<LordGymPassRecord>, IBufferMessage
	{
		// Token: 0x0600D3B7 RID: 54199 RVA: 0x001F3254 File Offset: 0x001F1454
		[NullableContext(1)]
		public static LordGymPassRecord Create()
		{
			return new LordGymPassRecord();
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x0600D3B8 RID: 54200 RVA: 0x001F325B File Offset: 0x001F145B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LordGymPassRecord> Parser
		{
			get
			{
				return LordGymPassRecord._parser;
			}
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x0600D3B9 RID: 54201 RVA: 0x001F3262 File Offset: 0x001F1462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x0600D3BA RID: 54202 RVA: 0x001F3265 File Offset: 0x001F1465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymPassRecord.Descriptor;
			}
		}

		// Token: 0x0600D3BB RID: 54203 RVA: 0x001F326C File Offset: 0x001F146C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymPassRecord()
		{
		}

		// Token: 0x0600D3BC RID: 54204 RVA: 0x001F3280 File Offset: 0x001F1480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymPassRecord(LordGymPassRecord other) : this()
		{
			this.loadGymId_ = other.loadGymId_;
			this.passTime_ = other.passTime_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3BD RID: 54205 RVA: 0x001F32CD File Offset: 0x001F14CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymPassRecord Clone()
		{
			return new LordGymPassRecord(this);
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x0600D3BE RID: 54206 RVA: 0x001F32D5 File Offset: 0x001F14D5
		// (set) Token: 0x0600D3BF RID: 54207 RVA: 0x001F32DD File Offset: 0x001F14DD
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

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x0600D3C0 RID: 54208 RVA: 0x001F32E6 File Offset: 0x001F14E6
		// (set) Token: 0x0600D3C1 RID: 54209 RVA: 0x001F32EE File Offset: 0x001F14EE
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

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x0600D3C2 RID: 54210 RVA: 0x001F32F7 File Offset: 0x001F14F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleBrief> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x0600D3C3 RID: 54211 RVA: 0x001F32FF File Offset: 0x001F14FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymPassRecord);
		}

		// Token: 0x0600D3C4 RID: 54212 RVA: 0x001F3310 File Offset: 0x001F1510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymPassRecord other)
		{
			return other != null && (other == this || (this.LoadGymId == other.LoadGymId && this.PassTime == other.PassTime && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3C5 RID: 54213 RVA: 0x001F3370 File Offset: 0x001F1570
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

		// Token: 0x0600D3C6 RID: 54214 RVA: 0x001F33D6 File Offset: 0x001F15D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3C7 RID: 54215 RVA: 0x001F33E3 File Offset: 0x001F15E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3C8 RID: 54216 RVA: 0x001F33EC File Offset: 0x001F15EC
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

		// Token: 0x0600D3C9 RID: 54217 RVA: 0x001F3458 File Offset: 0x001F1658
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

		// Token: 0x0600D3CA RID: 54218 RVA: 0x001F34C4 File Offset: 0x001F16C4
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

		// Token: 0x0600D3CB RID: 54219 RVA: 0x001F3525 File Offset: 0x001F1725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3CC RID: 54220 RVA: 0x001F3530 File Offset: 0x001F1730
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

		// Token: 0x040058F8 RID: 22776
		private static readonly MessageParser<LordGymPassRecord> _parser = new MessageParser<LordGymPassRecord>(() => new LordGymPassRecord());

		// Token: 0x040058F9 RID: 22777
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058FA RID: 22778
		public const int LoadGymIdFieldNumber = 1;

		// Token: 0x040058FB RID: 22779
		private int loadGymId_;

		// Token: 0x040058FC RID: 22780
		public const int PassTimeFieldNumber = 2;

		// Token: 0x040058FD RID: 22781
		private int passTime_;

		// Token: 0x040058FE RID: 22782
		public const int RoleIdsFieldNumber = 3;

		// Token: 0x040058FF RID: 22783
		private static readonly FieldCodec<RoleBrief> _repeated_roleIds_codec = FieldCodec.ForMessage<RoleBrief>(26U, RoleBrief.Parser);

		// Token: 0x04005900 RID: 22784
		private readonly RepeatedField<RoleBrief> roleIds_ = new RepeatedField<RoleBrief>();
	}
}
