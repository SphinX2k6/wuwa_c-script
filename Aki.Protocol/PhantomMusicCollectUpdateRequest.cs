using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD5 RID: 3285
	[NetMessage(EMessageId.PhantomMusicCollectUpdateRequest)]
	public sealed class PhantomMusicCollectUpdateRequest : IMessage<PhantomMusicCollectUpdateRequest>, IMessage, IEquatable<PhantomMusicCollectUpdateRequest>, IDeepCloneable<PhantomMusicCollectUpdateRequest>, IBufferMessage
	{
		// Token: 0x06011CC9 RID: 72905 RVA: 0x0029B4B3 File Offset: 0x002996B3
		[NullableContext(1)]
		public static PhantomMusicCollectUpdateRequest Create()
		{
			return new PhantomMusicCollectUpdateRequest();
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x06011CCA RID: 72906 RVA: 0x0029B4BA File Offset: 0x002996BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x06011CCB RID: 72907 RVA: 0x0029B4BD File Offset: 0x002996BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicCollectUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06011CCC RID: 72908 RVA: 0x0029B4C4 File Offset: 0x002996C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateRequest()
		{
		}

		// Token: 0x06011CCD RID: 72909 RVA: 0x0029B4D7 File Offset: 0x002996D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateRequest(PhantomMusicCollectUpdateRequest other) : this()
		{
			this.collectMusicIds_ = other.collectMusicIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011CCE RID: 72910 RVA: 0x0029B501 File Offset: 0x00299701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateRequest Clone()
		{
			return new PhantomMusicCollectUpdateRequest(this);
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x06011CCF RID: 72911 RVA: 0x0029B509 File Offset: 0x00299709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CollectMusicIds
		{
			get
			{
				return this.collectMusicIds_;
			}
		}

		// Token: 0x06011CD0 RID: 72912 RVA: 0x0029B511 File Offset: 0x00299711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicCollectUpdateRequest);
		}

		// Token: 0x06011CD1 RID: 72913 RVA: 0x0029B51F File Offset: 0x0029971F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicCollectUpdateRequest other)
		{
			return other != null && (other == this || (this.collectMusicIds_.Equals(other.collectMusicIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011CD2 RID: 72914 RVA: 0x0029B554 File Offset: 0x00299754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.collectMusicIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011CD3 RID: 72915 RVA: 0x0029B588 File Offset: 0x00299788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011CD4 RID: 72916 RVA: 0x0029B595 File Offset: 0x00299795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011CD5 RID: 72917 RVA: 0x0029B59E File Offset: 0x0029979E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.collectMusicIds_.WriteTo(ref output, PhantomMusicCollectUpdateRequest._repeated_collectMusicIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011CD6 RID: 72918 RVA: 0x0029B5C8 File Offset: 0x002997C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.collectMusicIds_.CalculateSize(PhantomMusicCollectUpdateRequest._repeated_collectMusicIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011CD7 RID: 72919 RVA: 0x0029B601 File Offset: 0x00299801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicCollectUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.collectMusicIds_.Add(other.collectMusicIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011CD8 RID: 72920 RVA: 0x0029B62F File Offset: 0x0029982F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CD9 RID: 72921 RVA: 0x0029B638 File Offset: 0x00299838
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.collectMusicIds_.AddEntriesFrom(ref input, PhantomMusicCollectUpdateRequest._repeated_collectMusicIds_codec);
				}
			}
		}

		// Token: 0x0400703E RID: 28734
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400703F RID: 28735
		public const int CollectMusicIdsFieldNumber = 6;

		// Token: 0x04007040 RID: 28736
		private static readonly FieldCodec<int> _repeated_collectMusicIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007041 RID: 28737
		private readonly RepeatedField<int> collectMusicIds_ = new RepeatedField<int>();
	}
}
