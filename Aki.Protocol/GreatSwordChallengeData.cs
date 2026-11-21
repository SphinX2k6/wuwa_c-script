using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000702 RID: 1794
	public sealed class GreatSwordChallengeData : IMessage<GreatSwordChallengeData>, IMessage, IEquatable<GreatSwordChallengeData>, IDeepCloneable<GreatSwordChallengeData>, IBufferMessage
	{
		// Token: 0x0600A38C RID: 41868 RVA: 0x0018B2B5 File Offset: 0x001894B5
		[NullableContext(1)]
		public static GreatSwordChallengeData Create()
		{
			return new GreatSwordChallengeData();
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x0600A38D RID: 41869 RVA: 0x0018B2BC File Offset: 0x001894BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x0600A38E RID: 41870 RVA: 0x0018B2BF File Offset: 0x001894BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GreatSwordChallengeData.Descriptor;
			}
		}

		// Token: 0x0600A38F RID: 41871 RVA: 0x0018B2C6 File Offset: 0x001894C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GreatSwordChallengeData()
		{
		}

		// Token: 0x0600A390 RID: 41872 RVA: 0x0018B2CE File Offset: 0x001894CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GreatSwordChallengeData(GreatSwordChallengeData other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A391 RID: 41873 RVA: 0x0018B2F3 File Offset: 0x001894F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GreatSwordChallengeData Clone()
		{
			return new GreatSwordChallengeData(this);
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x0600A392 RID: 41874 RVA: 0x0018B2FB File Offset: 0x001894FB
		// (set) Token: 0x0600A393 RID: 41875 RVA: 0x0018B303 File Offset: 0x00189503
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

		// Token: 0x0600A394 RID: 41876 RVA: 0x0018B30C File Offset: 0x0018950C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GreatSwordChallengeData);
		}

		// Token: 0x0600A395 RID: 41877 RVA: 0x0018B31A File Offset: 0x0018951A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GreatSwordChallengeData other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A396 RID: 41878 RVA: 0x0018B348 File Offset: 0x00189548
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

		// Token: 0x0600A397 RID: 41879 RVA: 0x0018B387 File Offset: 0x00189587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A398 RID: 41880 RVA: 0x0018B394 File Offset: 0x00189594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A399 RID: 41881 RVA: 0x0018B39D File Offset: 0x0018959D
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

		// Token: 0x0600A39A RID: 41882 RVA: 0x0018B3D0 File Offset: 0x001895D0
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

		// Token: 0x0600A39B RID: 41883 RVA: 0x0018B40E File Offset: 0x0018960E
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

		// Token: 0x0600A39C RID: 41884 RVA: 0x0018B43F File Offset: 0x0018963F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A39D RID: 41885 RVA: 0x0018B448 File Offset: 0x00189648
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

		// Token: 0x04004BDD RID: 19421
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BDE RID: 19422
		public const int IdFieldNumber = 1;

		// Token: 0x04004BDF RID: 19423
		private int id_;
	}
}
