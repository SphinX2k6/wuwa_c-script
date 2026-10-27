using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1C RID: 2588
	public sealed class MotorAnimEntity : IMessage<MotorAnimEntity>, IMessage, IEquatable<MotorAnimEntity>, IDeepCloneable<MotorAnimEntity>, IBufferMessage
	{
		// Token: 0x0600E254 RID: 57940 RVA: 0x002124CA File Offset: 0x002106CA
		[NullableContext(1)]
		public static MotorAnimEntity Create()
		{
			return new MotorAnimEntity();
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x0600E255 RID: 57941 RVA: 0x002124D1 File Offset: 0x002106D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorAnimEntity> Parser
		{
			get
			{
				return MotorAnimEntity._parser;
			}
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x0600E256 RID: 57942 RVA: 0x002124D8 File Offset: 0x002106D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x0600E257 RID: 57943 RVA: 0x002124DB File Offset: 0x002106DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorAnimEntity.Descriptor;
			}
		}

		// Token: 0x0600E258 RID: 57944 RVA: 0x002124E2 File Offset: 0x002106E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimEntity()
		{
		}

		// Token: 0x0600E259 RID: 57945 RVA: 0x002124F5 File Offset: 0x002106F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimEntity(MotorAnimEntity other) : this()
		{
			this.entityId_ = other.entityId_;
			this.motorAnimInfos_ = other.motorAnimInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E25A RID: 57946 RVA: 0x0021252B File Offset: 0x0021072B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimEntity Clone()
		{
			return new MotorAnimEntity(this);
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x0600E25B RID: 57947 RVA: 0x00212533 File Offset: 0x00210733
		// (set) Token: 0x0600E25C RID: 57948 RVA: 0x0021253B File Offset: 0x0021073B
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

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x0600E25D RID: 57949 RVA: 0x00212544 File Offset: 0x00210744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorAnimInfo> MotorAnimInfos
		{
			get
			{
				return this.motorAnimInfos_;
			}
		}

		// Token: 0x0600E25E RID: 57950 RVA: 0x0021254C File Offset: 0x0021074C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorAnimEntity);
		}

		// Token: 0x0600E25F RID: 57951 RVA: 0x0021255C File Offset: 0x0021075C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorAnimEntity other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.motorAnimInfos_.Equals(other.motorAnimInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E260 RID: 57952 RVA: 0x002125AC File Offset: 0x002107AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.motorAnimInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E261 RID: 57953 RVA: 0x002125F9 File Offset: 0x002107F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E262 RID: 57954 RVA: 0x00212606 File Offset: 0x00210806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E263 RID: 57955 RVA: 0x00212610 File Offset: 0x00210810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.motorAnimInfos_.WriteTo(ref output, MotorAnimEntity._repeated_motorAnimInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E264 RID: 57956 RVA: 0x00212660 File Offset: 0x00210860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.motorAnimInfos_.CalculateSize(MotorAnimEntity._repeated_motorAnimInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E265 RID: 57957 RVA: 0x002126B4 File Offset: 0x002108B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorAnimEntity other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.motorAnimInfos_.Add(other.motorAnimInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E266 RID: 57958 RVA: 0x00212701 File Offset: 0x00210901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E267 RID: 57959 RVA: 0x0021270C File Offset: 0x0021090C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.motorAnimInfos_.AddEntriesFrom(ref input, MotorAnimEntity._repeated_motorAnimInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005CED RID: 23789
		private static readonly MessageParser<MotorAnimEntity> _parser = new MessageParser<MotorAnimEntity>(() => new MotorAnimEntity());

		// Token: 0x04005CEE RID: 23790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CEF RID: 23791
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04005CF0 RID: 23792
		private long entityId_;

		// Token: 0x04005CF1 RID: 23793
		public const int MotorAnimInfosFieldNumber = 2;

		// Token: 0x04005CF2 RID: 23794
		private static readonly FieldCodec<MotorAnimInfo> _repeated_motorAnimInfos_codec = FieldCodec.ForMessage<MotorAnimInfo>(18U, MotorAnimInfo.Parser);

		// Token: 0x04005CF3 RID: 23795
		private readonly RepeatedField<MotorAnimInfo> motorAnimInfos_ = new RepeatedField<MotorAnimInfo>();
	}
}
