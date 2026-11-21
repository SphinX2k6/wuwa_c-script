using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000692 RID: 1682
	[NetMessage(EMessageId.GameplayCueNotify)]
	public sealed class GameplayCueNotify : IMessage<GameplayCueNotify>, IMessage, IEquatable<GameplayCueNotify>, IDeepCloneable<GameplayCueNotify>, IBufferMessage
	{
		// Token: 0x06009AF0 RID: 39664 RVA: 0x00179F8E File Offset: 0x0017818E
		[NullableContext(1)]
		public static GameplayCueNotify Create()
		{
			return new GameplayCueNotify();
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x06009AF1 RID: 39665 RVA: 0x00179F95 File Offset: 0x00178195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x06009AF2 RID: 39666 RVA: 0x00179F98 File Offset: 0x00178198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCueNotify.Descriptor;
			}
		}

		// Token: 0x06009AF3 RID: 39667 RVA: 0x00179F9F File Offset: 0x0017819F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueNotify()
		{
		}

		// Token: 0x06009AF4 RID: 39668 RVA: 0x00179FA7 File Offset: 0x001781A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueNotify(GameplayCueNotify other) : this()
		{
			this.cueConfigId_ = other.cueConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x00179FCC File Offset: 0x001781CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCueNotify Clone()
		{
			return new GameplayCueNotify(this);
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x06009AF6 RID: 39670 RVA: 0x00179FD4 File Offset: 0x001781D4
		// (set) Token: 0x06009AF7 RID: 39671 RVA: 0x00179FDC File Offset: 0x001781DC
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

		// Token: 0x06009AF8 RID: 39672 RVA: 0x00179FE5 File Offset: 0x001781E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCueNotify);
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x00179FF3 File Offset: 0x001781F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCueNotify other)
		{
			return other != null && (other == this || (this.CueConfigId == other.CueConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x0017A024 File Offset: 0x00178224
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

		// Token: 0x06009AFB RID: 39675 RVA: 0x0017A063 File Offset: 0x00178263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x0017A070 File Offset: 0x00178270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x0017A079 File Offset: 0x00178279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CueConfigId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.CueConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AFE RID: 39678 RVA: 0x0017A0AC File Offset: 0x001782AC
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

		// Token: 0x06009AFF RID: 39679 RVA: 0x0017A0EA File Offset: 0x001782EA
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

		// Token: 0x06009B00 RID: 39680 RVA: 0x0017A11B File Offset: 0x0017831B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B01 RID: 39681 RVA: 0x0017A124 File Offset: 0x00178324
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
					this.CueConfigId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040049B6 RID: 18870
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049B7 RID: 18871
		public const int CueConfigIdFieldNumber = 11;

		// Token: 0x040049B8 RID: 18872
		private long cueConfigId_;
	}
}
