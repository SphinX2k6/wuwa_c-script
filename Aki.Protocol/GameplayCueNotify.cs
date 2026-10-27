using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A6 RID: 1702
	[NetMessage(EMessageId.GameplayCueNotify)]
	public sealed class GameplayCueNotify : IMessage<GameplayCueNotify>, IMessage, IEquatable<GameplayCueNotify>, IDeepCloneable<GameplayCueNotify>, IBufferMessage
	{
		// Token: 0x06009C46 RID: 40006 RVA: 0x0017C9C6 File Offset: 0x0017ABC6
		[NullableContext(1)]
		public static GameplayCueNotify Create()
		{
			return new GameplayCueNotify();
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x06009C47 RID: 40007 RVA: 0x0017C9CD File Offset: 0x0017ABCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x06009C48 RID: 40008 RVA: 0x0017C9D0 File Offset: 0x0017ABD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCueNotify.Descriptor;
			}
		}

		// Token: 0x06009C49 RID: 40009 RVA: 0x0017C9D7 File Offset: 0x0017ABD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueNotify()
		{
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x0017C9DF File Offset: 0x0017ABDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueNotify(GameplayCueNotify other) : this()
		{
			this.cueConfigId_ = other.cueConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x0017CA04 File Offset: 0x0017AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueNotify Clone()
		{
			return new GameplayCueNotify(this);
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06009C4C RID: 40012 RVA: 0x0017CA0C File Offset: 0x0017AC0C
		// (set) Token: 0x06009C4D RID: 40013 RVA: 0x0017CA14 File Offset: 0x0017AC14
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

		// Token: 0x06009C4E RID: 40014 RVA: 0x0017CA1D File Offset: 0x0017AC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCueNotify);
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x0017CA2B File Offset: 0x0017AC2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCueNotify other)
		{
			return other != null && (other == this || (this.CueConfigId == other.CueConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x0017CA5C File Offset: 0x0017AC5C
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

		// Token: 0x06009C51 RID: 40017 RVA: 0x0017CA9B File Offset: 0x0017AC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C52 RID: 40018 RVA: 0x0017CAA8 File Offset: 0x0017ACA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C53 RID: 40019 RVA: 0x0017CAB1 File Offset: 0x0017ACB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CueConfigId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CueConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C54 RID: 40020 RVA: 0x0017CAE4 File Offset: 0x0017ACE4
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

		// Token: 0x06009C55 RID: 40021 RVA: 0x0017CB22 File Offset: 0x0017AD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCueNotify other)
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

		// Token: 0x06009C56 RID: 40022 RVA: 0x0017CB53 File Offset: 0x0017AD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x0017CB5C File Offset: 0x0017AD5C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CueConfigId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040049BD RID: 18877
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049BE RID: 18878
		public const int CueConfigIdFieldNumber = 4;

		// Token: 0x040049BF RID: 18879
		private long cueConfigId_;
	}
}
