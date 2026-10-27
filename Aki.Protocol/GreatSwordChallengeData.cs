using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000716 RID: 1814
	public sealed class GreatSwordChallengeData : IMessage<GreatSwordChallengeData>, IMessage, IEquatable<GreatSwordChallengeData>, IDeepCloneable<GreatSwordChallengeData>, IBufferMessage
	{
		// Token: 0x0600A4E2 RID: 42210 RVA: 0x0018DCE9 File Offset: 0x0018BEE9
		[NullableContext(1)]
		public static GreatSwordChallengeData Create()
		{
			return new GreatSwordChallengeData();
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x0600A4E3 RID: 42211 RVA: 0x0018DCF0 File Offset: 0x0018BEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x0600A4E4 RID: 42212 RVA: 0x0018DCF3 File Offset: 0x0018BEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GreatSwordChallengeData.Descriptor;
			}
		}

		// Token: 0x0600A4E5 RID: 42213 RVA: 0x0018DCFA File Offset: 0x0018BEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GreatSwordChallengeData()
		{
		}

		// Token: 0x0600A4E6 RID: 42214 RVA: 0x0018DD02 File Offset: 0x0018BF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GreatSwordChallengeData(GreatSwordChallengeData other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4E7 RID: 42215 RVA: 0x0018DD27 File Offset: 0x0018BF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GreatSwordChallengeData Clone()
		{
			return new GreatSwordChallengeData(this);
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x0600A4E8 RID: 42216 RVA: 0x0018DD2F File Offset: 0x0018BF2F
		// (set) Token: 0x0600A4E9 RID: 42217 RVA: 0x0018DD37 File Offset: 0x0018BF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x0018DD40 File Offset: 0x0018BF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GreatSwordChallengeData);
		}

		// Token: 0x0600A4EB RID: 42219 RVA: 0x0018DD4E File Offset: 0x0018BF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GreatSwordChallengeData other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4EC RID: 42220 RVA: 0x0018DD7C File Offset: 0x0018BF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4ED RID: 42221 RVA: 0x0018DDBB File Offset: 0x0018BFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4EE RID: 42222 RVA: 0x0018DDC8 File Offset: 0x0018BFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4EF RID: 42223 RVA: 0x0018DDD1 File Offset: 0x0018BFD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4F0 RID: 42224 RVA: 0x0018DE04 File Offset: 0x0018C004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A4F1 RID: 42225 RVA: 0x0018DE42 File Offset: 0x0018C042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GreatSwordChallengeData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A4F2 RID: 42226 RVA: 0x0018DE73 File Offset: 0x0018C073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4F3 RID: 42227 RVA: 0x0018DE7C File Offset: 0x0018C07C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004BE4 RID: 19428
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BE5 RID: 19429
		public const int IdFieldNumber = 1;

		// Token: 0x04004BE6 RID: 19430
		private int id_;
	}
}
