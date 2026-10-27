using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D0 RID: 464
	[NetMessage(EMessageId.BossRushBuffChooseResultRequest)]
	public sealed class BossRushBuffChooseResultRequest : IMessage<BossRushBuffChooseResultRequest>, IMessage, IEquatable<BossRushBuffChooseResultRequest>, IDeepCloneable<BossRushBuffChooseResultRequest>, IBufferMessage
	{
		// Token: 0x060034D6 RID: 13526 RVA: 0x000851A9 File Offset: 0x000833A9
		[NullableContext(1)]
		public static BossRushBuffChooseResultRequest Create()
		{
			return new BossRushBuffChooseResultRequest();
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060034D7 RID: 13527 RVA: 0x000851B0 File Offset: 0x000833B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x000851B3 File Offset: 0x000833B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushBuffChooseResultRequest.Descriptor;
			}
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x000851BA File Offset: 0x000833BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultRequest()
		{
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x000851C2 File Offset: 0x000833C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultRequest(BossRushBuffChooseResultRequest other) : this()
		{
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x000851E7 File Offset: 0x000833E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBuffChooseResultRequest Clone()
		{
			return new BossRushBuffChooseResultRequest(this);
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060034DC RID: 13532 RVA: 0x000851EF File Offset: 0x000833EF
		// (set) Token: 0x060034DD RID: 13533 RVA: 0x000851F7 File Offset: 0x000833F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x00085200 File Offset: 0x00083400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushBuffChooseResultRequest);
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x0008520E File Offset: 0x0008340E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushBuffChooseResultRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x0008523C File Offset: 0x0008343C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x0008527B File Offset: 0x0008347B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00085288 File Offset: 0x00083488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00085291 File Offset: 0x00083491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x000852C4 File Offset: 0x000834C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x00085302 File Offset: 0x00083502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushBuffChooseResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00085333 File Offset: 0x00083533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x0008533C File Offset: 0x0008353C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002A25 RID: 10789
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A26 RID: 10790
		public const int IndexFieldNumber = 11;

		// Token: 0x04002A27 RID: 10791
		private int index_;
	}
}
