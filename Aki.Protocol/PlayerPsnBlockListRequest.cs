using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA0 RID: 3488
	[NetMessage(EMessageId.PlayerPsnBlockListRequest)]
	public sealed class PlayerPsnBlockListRequest : IMessage<PlayerPsnBlockListRequest>, IMessage, IEquatable<PlayerPsnBlockListRequest>, IDeepCloneable<PlayerPsnBlockListRequest>, IBufferMessage
	{
		// Token: 0x06012CC4 RID: 76996 RVA: 0x002BDFCD File Offset: 0x002BC1CD
		[NullableContext(1)]
		public static PlayerPsnBlockListRequest Create()
		{
			return new PlayerPsnBlockListRequest();
		}

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x06012CC5 RID: 76997 RVA: 0x002BDFD4 File Offset: 0x002BC1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x06012CC6 RID: 76998 RVA: 0x002BDFD7 File Offset: 0x002BC1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerPsnBlockListRequest.Descriptor;
			}
		}

		// Token: 0x06012CC7 RID: 76999 RVA: 0x002BDFDE File Offset: 0x002BC1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListRequest()
		{
		}

		// Token: 0x06012CC8 RID: 77000 RVA: 0x002BDFF1 File Offset: 0x002BC1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListRequest(PlayerPsnBlockListRequest other) : this()
		{
			this.psnAccountIds_ = other.psnAccountIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012CC9 RID: 77001 RVA: 0x002BE01B File Offset: 0x002BC21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListRequest Clone()
		{
			return new PlayerPsnBlockListRequest(this);
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x06012CCA RID: 77002 RVA: 0x002BE023 File Offset: 0x002BC223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> PsnAccountIds
		{
			get
			{
				return this.psnAccountIds_;
			}
		}

		// Token: 0x06012CCB RID: 77003 RVA: 0x002BE02B File Offset: 0x002BC22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerPsnBlockListRequest);
		}

		// Token: 0x06012CCC RID: 77004 RVA: 0x002BE039 File Offset: 0x002BC239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerPsnBlockListRequest other)
		{
			return other != null && (other == this || (this.psnAccountIds_.Equals(other.psnAccountIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012CCD RID: 77005 RVA: 0x002BE06C File Offset: 0x002BC26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.psnAccountIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012CCE RID: 77006 RVA: 0x002BE0A0 File Offset: 0x002BC2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012CCF RID: 77007 RVA: 0x002BE0AD File Offset: 0x002BC2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012CD0 RID: 77008 RVA: 0x002BE0B6 File Offset: 0x002BC2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.psnAccountIds_.WriteTo(ref output, PlayerPsnBlockListRequest._repeated_psnAccountIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012CD1 RID: 77009 RVA: 0x002BE0E0 File Offset: 0x002BC2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.psnAccountIds_.CalculateSize(PlayerPsnBlockListRequest._repeated_psnAccountIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012CD2 RID: 77010 RVA: 0x002BE119 File Offset: 0x002BC319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerPsnBlockListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.psnAccountIds_.Add(other.psnAccountIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012CD3 RID: 77011 RVA: 0x002BE147 File Offset: 0x002BC347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012CD4 RID: 77012 RVA: 0x002BE150 File Offset: 0x002BC350
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.psnAccountIds_.AddEntriesFrom(ref input, PlayerPsnBlockListRequest._repeated_psnAccountIds_codec);
				}
			}
		}

		// Token: 0x0400746E RID: 29806
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400746F RID: 29807
		public const int PsnAccountIdsFieldNumber = 4;

		// Token: 0x04007470 RID: 29808
		private static readonly FieldCodec<string> _repeated_psnAccountIds_codec = FieldCodec.ForString(34U);

		// Token: 0x04007471 RID: 29809
		private readonly RepeatedField<string> psnAccountIds_ = new RepeatedField<string>();
	}
}
