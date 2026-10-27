using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000307 RID: 775
	[NetMessage(EMessageId.CorniceMeetingRewardRequest)]
	public sealed class CorniceMeetingRewardRequest : IMessage<CorniceMeetingRewardRequest>, IMessage, IEquatable<CorniceMeetingRewardRequest>, IDeepCloneable<CorniceMeetingRewardRequest>, IBufferMessage
	{
		// Token: 0x06004E32 RID: 20018 RVA: 0x000BDF75 File Offset: 0x000BC175
		[NullableContext(1)]
		public static CorniceMeetingRewardRequest Create()
		{
			return new CorniceMeetingRewardRequest();
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06004E33 RID: 20019 RVA: 0x000BDF7C File Offset: 0x000BC17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06004E34 RID: 20020 RVA: 0x000BDF7F File Offset: 0x000BC17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceMeetingRewardRequest.Descriptor;
			}
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x000BDF86 File Offset: 0x000BC186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardRequest()
		{
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x000BDF8E File Offset: 0x000BC18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardRequest(CorniceMeetingRewardRequest other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this.scoreIndex_ = other.scoreIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x000BDFBF File Offset: 0x000BC1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardRequest Clone()
		{
			return new CorniceMeetingRewardRequest(this);
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06004E38 RID: 20024 RVA: 0x000BDFC7 File Offset: 0x000BC1C7
		// (set) Token: 0x06004E39 RID: 20025 RVA: 0x000BDFCF File Offset: 0x000BC1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06004E3A RID: 20026 RVA: 0x000BDFD8 File Offset: 0x000BC1D8
		// (set) Token: 0x06004E3B RID: 20027 RVA: 0x000BDFE0 File Offset: 0x000BC1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScoreIndex
		{
			get
			{
				return this.scoreIndex_;
			}
			set
			{
				this.scoreIndex_ = value;
			}
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x000BDFE9 File Offset: 0x000BC1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceMeetingRewardRequest);
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x000BDFF7 File Offset: 0x000BC1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceMeetingRewardRequest other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && this.ScoreIndex == other.ScoreIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x000BE038 File Offset: 0x000BC238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this.ScoreIndex != 0)
			{
				num ^= this.ScoreIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E3F RID: 20031 RVA: 0x000BE090 File Offset: 0x000BC290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x000BE09D File Offset: 0x000BC29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x000BE0A8 File Offset: 0x000BC2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ScoreIndex);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x000BE104 File Offset: 0x000BC304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this.ScoreIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScoreIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x000BE15C File Offset: 0x000BC35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceMeetingRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			if (other.ScoreIndex != 0)
			{
				this.ScoreIndex = other.ScoreIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x000BE1AC File Offset: 0x000BC3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x000BE1B8 File Offset: 0x000BC3B8
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
				if (num != 40U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelPlayId = input.ReadInt32();
					}
				}
				else
				{
					this.ScoreIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003186 RID: 12678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003187 RID: 12679
		public const int LevelPlayIdFieldNumber = 11;

		// Token: 0x04003188 RID: 12680
		private int levelPlayId_;

		// Token: 0x04003189 RID: 12681
		public const int ScoreIndexFieldNumber = 5;

		// Token: 0x0400318A RID: 12682
		private int scoreIndex_;
	}
}
