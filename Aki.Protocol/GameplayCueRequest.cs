using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000694 RID: 1684
	[NetMessage(EMessageId.GameplayCueRequest)]
	public sealed class GameplayCueRequest : IMessage<GameplayCueRequest>, IMessage, IEquatable<GameplayCueRequest>, IDeepCloneable<GameplayCueRequest>, IBufferMessage
	{
		// Token: 0x06009B14 RID: 39700 RVA: 0x0017A341 File Offset: 0x00178541
		[NullableContext(1)]
		public static GameplayCueRequest Create()
		{
			return new GameplayCueRequest();
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06009B15 RID: 39701 RVA: 0x0017A348 File Offset: 0x00178548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06009B16 RID: 39702 RVA: 0x0017A34B File Offset: 0x0017854B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCueRequest.Descriptor;
			}
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x0017A352 File Offset: 0x00178552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueRequest()
		{
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x0017A35A File Offset: 0x0017855A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueRequest(GameplayCueRequest other) : this()
		{
			this.cueConfigId_ = other.cueConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x0017A37F File Offset: 0x0017857F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueRequest Clone()
		{
			return new GameplayCueRequest(this);
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06009B1A RID: 39706 RVA: 0x0017A387 File Offset: 0x00178587
		// (set) Token: 0x06009B1B RID: 39707 RVA: 0x0017A38F File Offset: 0x0017858F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CueConfigId
		{
			get
			{
				return this.cueConfigId_;
			}
			set
			{
				this.cueConfigId_ = value;
			}
		}

		// Token: 0x06009B1C RID: 39708 RVA: 0x0017A398 File Offset: 0x00178598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCueRequest);
		}

		// Token: 0x06009B1D RID: 39709 RVA: 0x0017A3A6 File Offset: 0x001785A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCueRequest other)
		{
			return other != null && (other == this || (this.CueConfigId == other.CueConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B1E RID: 39710 RVA: 0x0017A3D4 File Offset: 0x001785D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CueConfigId != 0L)
			{
				num ^= this.CueConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B1F RID: 39711 RVA: 0x0017A413 File Offset: 0x00178613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B20 RID: 39712 RVA: 0x0017A420 File Offset: 0x00178620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B21 RID: 39713 RVA: 0x0017A429 File Offset: 0x00178629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CueConfigId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.CueConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x0017A45C File Offset: 0x0017865C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CueConfigId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CueConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B23 RID: 39715 RVA: 0x0017A49A File Offset: 0x0017869A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCueRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CueConfigId != 0L)
			{
				this.CueConfigId = other.CueConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x0017A4CB File Offset: 0x001786CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x0017A4D4 File Offset: 0x001786D4
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CueConfigId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040049BC RID: 18876
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049BD RID: 18877
		public const int CueConfigIdFieldNumber = 6;

		// Token: 0x040049BE RID: 18878
		private long cueConfigId_;
	}
}
