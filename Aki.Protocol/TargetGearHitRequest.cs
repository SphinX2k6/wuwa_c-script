using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138B RID: 5003
	[NetMessage(EMessageId.TargetGearHitRequest)]
	public sealed class TargetGearHitRequest : IMessage<TargetGearHitRequest>, IMessage, IEquatable<TargetGearHitRequest>, IDeepCloneable<TargetGearHitRequest>, IBufferMessage
	{
		// Token: 0x0601AA32 RID: 109106 RVA: 0x003E1883 File Offset: 0x003DFA83
		[NullableContext(1)]
		public static TargetGearHitRequest Create()
		{
			return new TargetGearHitRequest();
		}

		// Token: 0x17005A31 RID: 23089
		// (get) Token: 0x0601AA33 RID: 109107 RVA: 0x003E188A File Offset: 0x003DFA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A32 RID: 23090
		// (get) Token: 0x0601AA34 RID: 109108 RVA: 0x003E188D File Offset: 0x003DFA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TargetGearHitRequest.Descriptor;
			}
		}

		// Token: 0x0601AA35 RID: 109109 RVA: 0x003E1894 File Offset: 0x003DFA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitRequest()
		{
		}

		// Token: 0x0601AA36 RID: 109110 RVA: 0x003E18B4 File Offset: 0x003DFAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitRequest(TargetGearHitRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.bulletTypes_ = other.bulletTypes_.Clone();
			this.bulletId_ = other.bulletId_;
			this.hitParts_ = other.hitParts_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA37 RID: 109111 RVA: 0x003E1912 File Offset: 0x003DFB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TargetGearHitRequest Clone()
		{
			return new TargetGearHitRequest(this);
		}

		// Token: 0x17005A33 RID: 23091
		// (get) Token: 0x0601AA38 RID: 109112 RVA: 0x003E191A File Offset: 0x003DFB1A
		// (set) Token: 0x0601AA39 RID: 109113 RVA: 0x003E1922 File Offset: 0x003DFB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005A34 RID: 23092
		// (get) Token: 0x0601AA3A RID: 109114 RVA: 0x003E192B File Offset: 0x003DFB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BulletTypes
		{
			get
			{
				return this.bulletTypes_;
			}
		}

		// Token: 0x17005A35 RID: 23093
		// (get) Token: 0x0601AA3B RID: 109115 RVA: 0x003E1933 File Offset: 0x003DFB33
		// (set) Token: 0x0601AA3C RID: 109116 RVA: 0x003E193B File Offset: 0x003DFB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BulletId
		{
			get
			{
				return this.bulletId_;
			}
			set
			{
				this.bulletId_ = value;
			}
		}

		// Token: 0x17005A36 RID: 23094
		// (get) Token: 0x0601AA3D RID: 109117 RVA: 0x003E1944 File Offset: 0x003DFB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> HitParts
		{
			get
			{
				return this.hitParts_;
			}
		}

		// Token: 0x0601AA3E RID: 109118 RVA: 0x003E194C File Offset: 0x003DFB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TargetGearHitRequest);
		}

		// Token: 0x0601AA3F RID: 109119 RVA: 0x003E195C File Offset: 0x003DFB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TargetGearHitRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.bulletTypes_.Equals(other.bulletTypes_) && this.BulletId == other.BulletId && this.hitParts_.Equals(other.hitParts_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA40 RID: 109120 RVA: 0x003E19D0 File Offset: 0x003DFBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.bulletTypes_.GetHashCode();
			if (this.BulletId != 0)
			{
				num ^= this.BulletId.GetHashCode();
			}
			num ^= this.hitParts_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AA41 RID: 109121 RVA: 0x003E1A44 File Offset: 0x003DFC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA42 RID: 109122 RVA: 0x003E1A51 File Offset: 0x003DFC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA43 RID: 109123 RVA: 0x003E1A5C File Offset: 0x003DFC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BulletId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			this.bulletTypes_.WriteTo(ref output, TargetGearHitRequest._repeated_bulletTypes_codec);
			this.hitParts_.WriteTo(ref output, TargetGearHitRequest._repeated_hitParts_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA44 RID: 109124 RVA: 0x003E1AD8 File Offset: 0x003DFCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.bulletTypes_.CalculateSize(TargetGearHitRequest._repeated_bulletTypes_codec);
			if (this.BulletId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BulletId);
			}
			num += this.hitParts_.CalculateSize(TargetGearHitRequest._repeated_hitParts_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AA45 RID: 109125 RVA: 0x003E1B54 File Offset: 0x003DFD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TargetGearHitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.bulletTypes_.Add(other.bulletTypes_);
			if (other.BulletId != 0)
			{
				this.BulletId = other.BulletId;
			}
			this.hitParts_.Add(other.hitParts_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AA46 RID: 109126 RVA: 0x003E1BC6 File Offset: 0x003DFDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA47 RID: 109127 RVA: 0x003E1BD0 File Offset: 0x003DFDD0
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
				if (num <= 56U)
				{
					if (num == 48U)
					{
						this.BulletId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 64U || num == 66U)
					{
						this.bulletTypes_.AddEntriesFrom(ref input, TargetGearHitRequest._repeated_bulletTypes_codec);
						continue;
					}
					if (num == 74U)
					{
						this.hitParts_.AddEntriesFrom(ref input, TargetGearHitRequest._repeated_hitParts_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009C14 RID: 39956
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C15 RID: 39957
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04009C16 RID: 39958
		private long entityId_;

		// Token: 0x04009C17 RID: 39959
		public const int BulletTypesFieldNumber = 8;

		// Token: 0x04009C18 RID: 39960
		private static readonly FieldCodec<int> _repeated_bulletTypes_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04009C19 RID: 39961
		private readonly RepeatedField<int> bulletTypes_ = new RepeatedField<int>();

		// Token: 0x04009C1A RID: 39962
		public const int BulletIdFieldNumber = 6;

		// Token: 0x04009C1B RID: 39963
		private int bulletId_;

		// Token: 0x04009C1C RID: 39964
		public const int HitPartsFieldNumber = 9;

		// Token: 0x04009C1D RID: 39965
		private static readonly FieldCodec<string> _repeated_hitParts_codec = FieldCodec.ForString(74U);

		// Token: 0x04009C1E RID: 39966
		private readonly RepeatedField<string> hitParts_ = new RepeatedField<string>();
	}
}
