using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE5 RID: 3301
	[NetMessage(EMessageId.PhantomMusicCollectUpdateRequest)]
	public sealed class PhantomMusicCollectUpdateRequest : IMessage<PhantomMusicCollectUpdateRequest>, IMessage, IEquatable<PhantomMusicCollectUpdateRequest>, IDeepCloneable<PhantomMusicCollectUpdateRequest>, IBufferMessage
	{
		// Token: 0x06011DC5 RID: 73157 RVA: 0x0029D0C7 File Offset: 0x0029B2C7
		[NullableContext(1)]
		public static PhantomMusicCollectUpdateRequest Create()
		{
			return new PhantomMusicCollectUpdateRequest();
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x06011DC6 RID: 73158 RVA: 0x0029D0CE File Offset: 0x0029B2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x06011DC7 RID: 73159 RVA: 0x0029D0D1 File Offset: 0x0029B2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicCollectUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06011DC8 RID: 73160 RVA: 0x0029D0D8 File Offset: 0x0029B2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateRequest()
		{
		}

		// Token: 0x06011DC9 RID: 73161 RVA: 0x0029D0EB File Offset: 0x0029B2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateRequest(PhantomMusicCollectUpdateRequest other) : this()
		{
			this.collectMusicIds_ = other.collectMusicIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011DCA RID: 73162 RVA: 0x0029D115 File Offset: 0x0029B315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateRequest Clone()
		{
			return new PhantomMusicCollectUpdateRequest(this);
		}

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x06011DCB RID: 73163 RVA: 0x0029D11D File Offset: 0x0029B31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CollectMusicIds
		{
			get
			{
				return this.collectMusicIds_;
			}
		}

		// Token: 0x06011DCC RID: 73164 RVA: 0x0029D125 File Offset: 0x0029B325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicCollectUpdateRequest);
		}

		// Token: 0x06011DCD RID: 73165 RVA: 0x0029D133 File Offset: 0x0029B333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicCollectUpdateRequest other)
		{
			return other != null && (other == this || (this.collectMusicIds_.Equals(other.collectMusicIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011DCE RID: 73166 RVA: 0x0029D168 File Offset: 0x0029B368
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

		// Token: 0x06011DCF RID: 73167 RVA: 0x0029D19C File Offset: 0x0029B39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011DD0 RID: 73168 RVA: 0x0029D1A9 File Offset: 0x0029B3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011DD1 RID: 73169 RVA: 0x0029D1B2 File Offset: 0x0029B3B2
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

		// Token: 0x06011DD2 RID: 73170 RVA: 0x0029D1DC File Offset: 0x0029B3DC
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

		// Token: 0x06011DD3 RID: 73171 RVA: 0x0029D215 File Offset: 0x0029B415
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

		// Token: 0x06011DD4 RID: 73172 RVA: 0x0029D243 File Offset: 0x0029B443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011DD5 RID: 73173 RVA: 0x0029D24C File Offset: 0x0029B44C
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.collectMusicIds_.AddEntriesFrom(ref input, PhantomMusicCollectUpdateRequest._repeated_collectMusicIds_codec);
				}
			}
		}

		// Token: 0x04007026 RID: 28710
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007027 RID: 28711
		public const int CollectMusicIdsFieldNumber = 8;

		// Token: 0x04007028 RID: 28712
		private static readonly FieldCodec<int> _repeated_collectMusicIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04007029 RID: 28713
		private readonly RepeatedField<int> collectMusicIds_ = new RepeatedField<int>();
	}
}
