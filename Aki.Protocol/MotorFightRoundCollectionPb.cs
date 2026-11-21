using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4F RID: 2639
	public sealed class MotorFightRoundCollectionPb : IMessage<MotorFightRoundCollectionPb>, IMessage, IEquatable<MotorFightRoundCollectionPb>, IDeepCloneable<MotorFightRoundCollectionPb>, IBufferMessage
	{
		// Token: 0x0600E695 RID: 59029 RVA: 0x0021B64A File Offset: 0x0021984A
		[NullableContext(1)]
		public static MotorFightRoundCollectionPb Create()
		{
			return new MotorFightRoundCollectionPb();
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x0600E696 RID: 59030 RVA: 0x0021B651 File Offset: 0x00219851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightRoundCollectionPb> Parser
		{
			get
			{
				return MotorFightRoundCollectionPb._parser;
			}
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x0600E697 RID: 59031 RVA: 0x0021B658 File Offset: 0x00219858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x0600E698 RID: 59032 RVA: 0x0021B65B File Offset: 0x0021985B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRoundCollectionPb.Descriptor;
			}
		}

		// Token: 0x0600E699 RID: 59033 RVA: 0x0021B662 File Offset: 0x00219862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundCollectionPb()
		{
		}

		// Token: 0x0600E69A RID: 59034 RVA: 0x0021B66A File Offset: 0x0021986A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundCollectionPb(MotorFightRoundCollectionPb other) : this()
		{
			this.collectionId_ = other.collectionId_;
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E69B RID: 59035 RVA: 0x0021B6A7 File Offset: 0x002198A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundCollectionPb Clone()
		{
			return new MotorFightRoundCollectionPb(this);
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0600E69C RID: 59036 RVA: 0x0021B6AF File Offset: 0x002198AF
		// (set) Token: 0x0600E69D RID: 59037 RVA: 0x0021B6B7 File Offset: 0x002198B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CollectionId
		{
			get
			{
				return this.collectionId_;
			}
			set
			{
				this.collectionId_ = value;
			}
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0600E69E RID: 59038 RVA: 0x0021B6C0 File Offset: 0x002198C0
		// (set) Token: 0x0600E69F RID: 59039 RVA: 0x0021B6C8 File Offset: 0x002198C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelIndex
		{
			get
			{
				return this.subLevelIndex_;
			}
			set
			{
				this.subLevelIndex_ = value;
			}
		}

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x0600E6A0 RID: 59040 RVA: 0x0021B6D1 File Offset: 0x002198D1
		// (set) Token: 0x0600E6A1 RID: 59041 RVA: 0x0021B6D9 File Offset: 0x002198D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveGroupIndex
		{
			get
			{
				return this.waveGroupIndex_;
			}
			set
			{
				this.waveGroupIndex_ = value;
			}
		}

		// Token: 0x0600E6A2 RID: 59042 RVA: 0x0021B6E2 File Offset: 0x002198E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRoundCollectionPb);
		}

		// Token: 0x0600E6A3 RID: 59043 RVA: 0x0021B6F0 File Offset: 0x002198F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRoundCollectionPb other)
		{
			return other != null && (other == this || (this.CollectionId == other.CollectionId && this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6A4 RID: 59044 RVA: 0x0021B74C File Offset: 0x0021994C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CollectionId != 0)
			{
				num ^= this.CollectionId.GetHashCode();
			}
			if (this.SubLevelIndex != 0)
			{
				num ^= this.SubLevelIndex.GetHashCode();
			}
			if (this.WaveGroupIndex != 0)
			{
				num ^= this.WaveGroupIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E6A5 RID: 59045 RVA: 0x0021B7BD File Offset: 0x002199BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E6A6 RID: 59046 RVA: 0x0021B7CA File Offset: 0x002199CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6A7 RID: 59047 RVA: 0x0021B7D4 File Offset: 0x002199D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CollectionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CollectionId);
			}
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6A8 RID: 59048 RVA: 0x0021B848 File Offset: 0x00219A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CollectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CollectionId);
			}
			if (this.SubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveGroupIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E6A9 RID: 59049 RVA: 0x0021B8B8 File Offset: 0x00219AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRoundCollectionPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CollectionId != 0)
			{
				this.CollectionId = other.CollectionId;
			}
			if (other.SubLevelIndex != 0)
			{
				this.SubLevelIndex = other.SubLevelIndex;
			}
			if (other.WaveGroupIndex != 0)
			{
				this.WaveGroupIndex = other.WaveGroupIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E6AA RID: 59050 RVA: 0x0021B91C File Offset: 0x00219B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6AB RID: 59051 RVA: 0x0021B928 File Offset: 0x00219B28
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.WaveGroupIndex = input.ReadInt32();
						}
					}
					else
					{
						this.SubLevelIndex = input.ReadInt32();
					}
				}
				else
				{
					this.CollectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E6C RID: 24172
		private static readonly MessageParser<MotorFightRoundCollectionPb> _parser = new MessageParser<MotorFightRoundCollectionPb>(() => new MotorFightRoundCollectionPb());

		// Token: 0x04005E6D RID: 24173
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E6E RID: 24174
		public const int CollectionIdFieldNumber = 1;

		// Token: 0x04005E6F RID: 24175
		private int collectionId_;

		// Token: 0x04005E70 RID: 24176
		public const int SubLevelIndexFieldNumber = 2;

		// Token: 0x04005E71 RID: 24177
		private int subLevelIndex_;

		// Token: 0x04005E72 RID: 24178
		public const int WaveGroupIndexFieldNumber = 3;

		// Token: 0x04005E73 RID: 24179
		private int waveGroupIndex_;
	}
}
