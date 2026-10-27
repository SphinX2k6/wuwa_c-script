using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1B RID: 2587
	[NetMessage(EMessageId.MoraleTreasureBoxTraceResponse)]
	public sealed class MoraleTreasureBoxTraceResponse : IMessage<MoraleTreasureBoxTraceResponse>, IMessage, IEquatable<MoraleTreasureBoxTraceResponse>, IDeepCloneable<MoraleTreasureBoxTraceResponse>, IBufferMessage
	{
		// Token: 0x0600E23E RID: 57918 RVA: 0x00212161 File Offset: 0x00210361
		[NullableContext(1)]
		public static MoraleTreasureBoxTraceResponse Create()
		{
			return new MoraleTreasureBoxTraceResponse();
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x0600E23F RID: 57919 RVA: 0x00212168 File Offset: 0x00210368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x0600E240 RID: 57920 RVA: 0x0021216B File Offset: 0x0021036B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoraleTreasureBoxTraceResponse.Descriptor;
			}
		}

		// Token: 0x0600E241 RID: 57921 RVA: 0x00212172 File Offset: 0x00210372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceResponse()
		{
		}

		// Token: 0x0600E242 RID: 57922 RVA: 0x00212188 File Offset: 0x00210388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceResponse(MoraleTreasureBoxTraceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.areaPos_ = other.areaPos_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E243 RID: 57923 RVA: 0x002121D5 File Offset: 0x002103D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceResponse Clone()
		{
			return new MoraleTreasureBoxTraceResponse(this);
		}

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x0600E244 RID: 57924 RVA: 0x002121DD File Offset: 0x002103DD
		// (set) Token: 0x0600E245 RID: 57925 RVA: 0x002121E5 File Offset: 0x002103E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x0600E246 RID: 57926 RVA: 0x002121EE File Offset: 0x002103EE
		// (set) Token: 0x0600E247 RID: 57927 RVA: 0x002121F6 File Offset: 0x002103F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaPos
		{
			get
			{
				return this.areaPos_;
			}
			set
			{
				this.areaPos_ = value;
			}
		}

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x0600E248 RID: 57928 RVA: 0x002121FF File Offset: 0x002103FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0600E249 RID: 57929 RVA: 0x00212207 File Offset: 0x00210407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoraleTreasureBoxTraceResponse);
		}

		// Token: 0x0600E24A RID: 57930 RVA: 0x00212218 File Offset: 0x00210418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoraleTreasureBoxTraceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.AreaPos == other.AreaPos && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E24B RID: 57931 RVA: 0x00212278 File Offset: 0x00210478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.AreaPos != 0)
			{
				num ^= this.AreaPos.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E24C RID: 57932 RVA: 0x002122E4 File Offset: 0x002104E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E24D RID: 57933 RVA: 0x002122F1 File Offset: 0x002104F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E24E RID: 57934 RVA: 0x002122FC File Offset: 0x002104FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, MoraleTreasureBoxTraceResponse._repeated_entityIds_codec);
			if (this.AreaPos != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.AreaPos);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E24F RID: 57935 RVA: 0x00212368 File Offset: 0x00210568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.AreaPos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaPos);
			}
			num += this.entityIds_.CalculateSize(MoraleTreasureBoxTraceResponse._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E250 RID: 57936 RVA: 0x002123D4 File Offset: 0x002105D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoraleTreasureBoxTraceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.AreaPos != 0)
			{
				this.AreaPos = other.AreaPos;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E251 RID: 57937 RVA: 0x00212435 File Offset: 0x00210635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E252 RID: 57938 RVA: 0x00212440 File Offset: 0x00210640
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
				if (num <= 66U)
				{
					if (num == 64U || num == 66U)
					{
						this.entityIds_.AddEntriesFrom(ref input, MoraleTreasureBoxTraceResponse._repeated_entityIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.AreaPos = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005CE5 RID: 23781
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CE6 RID: 23782
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04005CE7 RID: 23783
		private ErrorCode errorCode_;

		// Token: 0x04005CE8 RID: 23784
		public const int AreaPosFieldNumber = 10;

		// Token: 0x04005CE9 RID: 23785
		private int areaPos_;

		// Token: 0x04005CEA RID: 23786
		public const int EntityIdsFieldNumber = 8;

		// Token: 0x04005CEB RID: 23787
		private static readonly FieldCodec<int> _repeated_entityIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04005CEC RID: 23788
		private readonly RepeatedField<int> entityIds_ = new RepeatedField<int>();
	}
}
