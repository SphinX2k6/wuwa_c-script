using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001155 RID: 4437
	[NetMessage(EMessageId.SceneGamePlayScopeNotify)]
	public sealed class SceneGamePlayScopeNotify : IMessage<SceneGamePlayScopeNotify>, IMessage, IEquatable<SceneGamePlayScopeNotify>, IDeepCloneable<SceneGamePlayScopeNotify>, IBufferMessage
	{
		// Token: 0x06017A6D RID: 96877 RVA: 0x0036EE23 File Offset: 0x0036D023
		[NullableContext(1)]
		public static SceneGamePlayScopeNotify Create()
		{
			return new SceneGamePlayScopeNotify();
		}

		// Token: 0x17004F61 RID: 20321
		// (get) Token: 0x06017A6E RID: 96878 RVA: 0x0036EE2A File Offset: 0x0036D02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F62 RID: 20322
		// (get) Token: 0x06017A6F RID: 96879 RVA: 0x0036EE2D File Offset: 0x0036D02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayScopeNotify.Descriptor;
			}
		}

		// Token: 0x06017A70 RID: 96880 RVA: 0x0036EE34 File Offset: 0x0036D034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayScopeNotify()
		{
		}

		// Token: 0x06017A71 RID: 96881 RVA: 0x0036EE3C File Offset: 0x0036D03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayScopeNotify(SceneGamePlayScopeNotify other) : this()
		{
			this.gamePlayId_ = other.gamePlayId_;
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A72 RID: 96882 RVA: 0x0036EE6D File Offset: 0x0036D06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayScopeNotify Clone()
		{
			return new SceneGamePlayScopeNotify(this);
		}

		// Token: 0x17004F63 RID: 20323
		// (get) Token: 0x06017A73 RID: 96883 RVA: 0x0036EE75 File Offset: 0x0036D075
		// (set) Token: 0x06017A74 RID: 96884 RVA: 0x0036EE7D File Offset: 0x0036D07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamePlayId
		{
			get
			{
				return this.gamePlayId_;
			}
			set
			{
				this.gamePlayId_ = value;
			}
		}

		// Token: 0x17004F64 RID: 20324
		// (get) Token: 0x06017A75 RID: 96885 RVA: 0x0036EE86 File Offset: 0x0036D086
		// (set) Token: 0x06017A76 RID: 96886 RVA: 0x0036EE8E File Offset: 0x0036D08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x06017A77 RID: 96887 RVA: 0x0036EE97 File Offset: 0x0036D097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayScopeNotify);
		}

		// Token: 0x06017A78 RID: 96888 RVA: 0x0036EEA5 File Offset: 0x0036D0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayScopeNotify other)
		{
			return other != null && (other == this || (this.GamePlayId == other.GamePlayId && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A79 RID: 96889 RVA: 0x0036EEE4 File Offset: 0x0036D0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A7A RID: 96890 RVA: 0x0036EF3C File Offset: 0x0036D13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A7B RID: 96891 RVA: 0x0036EF49 File Offset: 0x0036D149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A7C RID: 96892 RVA: 0x0036EF54 File Offset: 0x0036D154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsEnter)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsEnter);
			}
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.GamePlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A7D RID: 96893 RVA: 0x0036EFB0 File Offset: 0x0036D1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A7E RID: 96894 RVA: 0x0036EFFC File Offset: 0x0036D1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayScopeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A7F RID: 96895 RVA: 0x0036F04C File Offset: 0x0036D24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A80 RID: 96896 RVA: 0x0036F058 File Offset: 0x0036D258
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
				if (num != 80U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GamePlayId = input.ReadInt32();
					}
				}
				else
				{
					this.IsEnter = input.ReadBool();
				}
			}
		}

		// Token: 0x04008C5D RID: 35933
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C5E RID: 35934
		public const int GamePlayIdFieldNumber = 11;

		// Token: 0x04008C5F RID: 35935
		private int gamePlayId_;

		// Token: 0x04008C60 RID: 35936
		public const int IsEnterFieldNumber = 10;

		// Token: 0x04008C61 RID: 35937
		private bool isEnter_;
	}
}
