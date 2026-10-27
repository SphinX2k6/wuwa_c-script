using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A7 RID: 1703
	[NetMessage(EMessageId.GameplayCuePush)]
	public sealed class GameplayCuePush : IMessage<GameplayCuePush>, IMessage, IEquatable<GameplayCuePush>, IDeepCloneable<GameplayCuePush>, IBufferMessage
	{
		// Token: 0x06009C58 RID: 40024 RVA: 0x0017CBA1 File Offset: 0x0017ADA1
		[NullableContext(1)]
		public static GameplayCuePush Create()
		{
			return new GameplayCuePush();
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06009C59 RID: 40025 RVA: 0x0017CBA8 File Offset: 0x0017ADA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06009C5A RID: 40026 RVA: 0x0017CBAB File Offset: 0x0017ADAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCuePush.Descriptor;
			}
		}

		// Token: 0x06009C5B RID: 40027 RVA: 0x0017CBB2 File Offset: 0x0017ADB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCuePush()
		{
		}

		// Token: 0x06009C5C RID: 40028 RVA: 0x0017CBBA File Offset: 0x0017ADBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCuePush(GameplayCuePush other) : this()
		{
			this.cueConfigId_ = other.cueConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C5D RID: 40029 RVA: 0x0017CBDF File Offset: 0x0017ADDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCuePush Clone()
		{
			return new GameplayCuePush(this);
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06009C5E RID: 40030 RVA: 0x0017CBE7 File Offset: 0x0017ADE7
		// (set) Token: 0x06009C5F RID: 40031 RVA: 0x0017CBEF File Offset: 0x0017ADEF
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

		// Token: 0x06009C60 RID: 40032 RVA: 0x0017CBF8 File Offset: 0x0017ADF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCuePush);
		}

		// Token: 0x06009C61 RID: 40033 RVA: 0x0017CC06 File Offset: 0x0017AE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCuePush other)
		{
			return other != null && (other == this || (this.CueConfigId == other.CueConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C62 RID: 40034 RVA: 0x0017CC34 File Offset: 0x0017AE34
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

		// Token: 0x06009C63 RID: 40035 RVA: 0x0017CC73 File Offset: 0x0017AE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C64 RID: 40036 RVA: 0x0017CC80 File Offset: 0x0017AE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C65 RID: 40037 RVA: 0x0017CC89 File Offset: 0x0017AE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CueConfigId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CueConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C66 RID: 40038 RVA: 0x0017CCBC File Offset: 0x0017AEBC
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

		// Token: 0x06009C67 RID: 40039 RVA: 0x0017CCFA File Offset: 0x0017AEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCuePush other)
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

		// Token: 0x06009C68 RID: 40040 RVA: 0x0017CD2B File Offset: 0x0017AF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x0017CD34 File Offset: 0x0017AF34
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CueConfigId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040049C0 RID: 18880
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049C1 RID: 18881
		public const int CueConfigIdFieldNumber = 3;

		// Token: 0x040049C2 RID: 18882
		private long cueConfigId_;
	}
}
