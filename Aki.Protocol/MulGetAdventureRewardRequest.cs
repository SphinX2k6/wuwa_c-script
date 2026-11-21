using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACD RID: 2765
	[NetMessage(EMessageId.MulGetAdventureRewardRequest)]
	public sealed class MulGetAdventureRewardRequest : IMessage<MulGetAdventureRewardRequest>, IMessage, IEquatable<MulGetAdventureRewardRequest>, IDeepCloneable<MulGetAdventureRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F0F1 RID: 61681 RVA: 0x0023368C File Offset: 0x0023188C
		[NullableContext(1)]
		public static MulGetAdventureRewardRequest Create()
		{
			return new MulGetAdventureRewardRequest();
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x0600F0F2 RID: 61682 RVA: 0x00233693 File Offset: 0x00231893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x0600F0F3 RID: 61683 RVA: 0x00233696 File Offset: 0x00231896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulGetAdventureRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F0F4 RID: 61684 RVA: 0x0023369D File Offset: 0x0023189D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardRequest()
		{
		}

		// Token: 0x0600F0F5 RID: 61685 RVA: 0x002336B0 File Offset: 0x002318B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardRequest(MulGetAdventureRewardRequest other) : this()
		{
			this.id_ = other.id_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F0F6 RID: 61686 RVA: 0x002336DA File Offset: 0x002318DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardRequest Clone()
		{
			return new MulGetAdventureRewardRequest(this);
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x0600F0F7 RID: 61687 RVA: 0x002336E2 File Offset: 0x002318E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Id
		{
			get
			{
				return this.id_;
			}
		}

		// Token: 0x0600F0F8 RID: 61688 RVA: 0x002336EA File Offset: 0x002318EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulGetAdventureRewardRequest);
		}

		// Token: 0x0600F0F9 RID: 61689 RVA: 0x002336F8 File Offset: 0x002318F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulGetAdventureRewardRequest other)
		{
			return other != null && (other == this || (this.id_.Equals(other.id_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F0FA RID: 61690 RVA: 0x0023372C File Offset: 0x0023192C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.id_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F0FB RID: 61691 RVA: 0x00233760 File Offset: 0x00231960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F0FC RID: 61692 RVA: 0x0023376D File Offset: 0x0023196D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F0FD RID: 61693 RVA: 0x00233776 File Offset: 0x00231976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.id_.WriteTo(ref output, MulGetAdventureRewardRequest._repeated_id_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F0FE RID: 61694 RVA: 0x002337A0 File Offset: 0x002319A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.id_.CalculateSize(MulGetAdventureRewardRequest._repeated_id_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F0FF RID: 61695 RVA: 0x002337D9 File Offset: 0x002319D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulGetAdventureRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.id_.Add(other.id_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F100 RID: 61696 RVA: 0x00233807 File Offset: 0x00231A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F101 RID: 61697 RVA: 0x00233810 File Offset: 0x00231A10
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.id_.AddEntriesFrom(ref input, MulGetAdventureRewardRequest._repeated_id_codec);
				}
			}
		}

		// Token: 0x040061BB RID: 25019
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061BC RID: 25020
		public const int IdFieldNumber = 9;

		// Token: 0x040061BD RID: 25021
		private static readonly FieldCodec<int> _repeated_id_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040061BE RID: 25022
		private readonly RepeatedField<int> id_ = new RepeatedField<int>();
	}
}
