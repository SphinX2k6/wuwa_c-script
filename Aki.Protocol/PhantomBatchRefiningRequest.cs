using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C12 RID: 3090
	[NetMessage(EMessageId.PhantomBatchRefiningRequest)]
	public sealed class PhantomBatchRefiningRequest : IMessage<PhantomBatchRefiningRequest>, IMessage, IEquatable<PhantomBatchRefiningRequest>, IDeepCloneable<PhantomBatchRefiningRequest>, IBufferMessage
	{
		// Token: 0x06010CB4 RID: 68788 RVA: 0x0027625C File Offset: 0x0027445C
		[NullableContext(1)]
		public static PhantomBatchRefiningRequest Create()
		{
			return new PhantomBatchRefiningRequest();
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x06010CB5 RID: 68789 RVA: 0x00276263 File Offset: 0x00274463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x06010CB6 RID: 68790 RVA: 0x00276266 File Offset: 0x00274466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchRefiningRequest.Descriptor;
			}
		}

		// Token: 0x06010CB7 RID: 68791 RVA: 0x0027626D File Offset: 0x0027446D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningRequest()
		{
		}

		// Token: 0x06010CB8 RID: 68792 RVA: 0x00276280 File Offset: 0x00274480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningRequest(PhantomBatchRefiningRequest other) : this()
		{
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010CB9 RID: 68793 RVA: 0x002762AA File Offset: 0x002744AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningRequest Clone()
		{
			return new PhantomBatchRefiningRequest(this);
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x06010CBA RID: 68794 RVA: 0x002762B2 File Offset: 0x002744B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06010CBB RID: 68795 RVA: 0x002762BA File Offset: 0x002744BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchRefiningRequest);
		}

		// Token: 0x06010CBC RID: 68796 RVA: 0x002762C8 File Offset: 0x002744C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchRefiningRequest other)
		{
			return other != null && (other == this || (this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010CBD RID: 68797 RVA: 0x002762FC File Offset: 0x002744FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stackEntries_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010CBE RID: 68798 RVA: 0x00276330 File Offset: 0x00274530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010CBF RID: 68799 RVA: 0x0027633D File Offset: 0x0027453D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010CC0 RID: 68800 RVA: 0x00276346 File Offset: 0x00274546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackEntries_.WriteTo(ref output, PhantomBatchRefiningRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010CC1 RID: 68801 RVA: 0x00276370 File Offset: 0x00274570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stackEntries_.CalculateSize(PhantomBatchRefiningRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010CC2 RID: 68802 RVA: 0x002763A9 File Offset: 0x002745A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBatchRefiningRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.stackEntries_.Add(other.stackEntries_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010CC3 RID: 68803 RVA: 0x002763D7 File Offset: 0x002745D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010CC4 RID: 68804 RVA: 0x002763E0 File Offset: 0x002745E0
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stackEntries_.AddEntriesFrom(ref input, PhantomBatchRefiningRequest._repeated_stackEntries_codec);
				}
			}
		}

		// Token: 0x04006B15 RID: 27413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B16 RID: 27414
		public const int StackEntriesFieldNumber = 6;

		// Token: 0x04006B17 RID: 27415
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(50U, PhantomStackConsumeEntry.Parser);

		// Token: 0x04006B18 RID: 27416
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
