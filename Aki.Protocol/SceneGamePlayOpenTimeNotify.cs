using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118E RID: 4494
	[NetMessage(EMessageId.SceneGamePlayOpenTimeNotify)]
	public sealed class SceneGamePlayOpenTimeNotify : IMessage<SceneGamePlayOpenTimeNotify>, IMessage, IEquatable<SceneGamePlayOpenTimeNotify>, IDeepCloneable<SceneGamePlayOpenTimeNotify>, IBufferMessage
	{
		// Token: 0x06017FFA RID: 98298 RVA: 0x0037DED9 File Offset: 0x0037C0D9
		[NullableContext(1)]
		public static SceneGamePlayOpenTimeNotify Create()
		{
			return new SceneGamePlayOpenTimeNotify();
		}

		// Token: 0x170050C9 RID: 20681
		// (get) Token: 0x06017FFB RID: 98299 RVA: 0x0037DEE0 File Offset: 0x0037C0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050CA RID: 20682
		// (get) Token: 0x06017FFC RID: 98300 RVA: 0x0037DEE3 File Offset: 0x0037C0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayOpenTimeNotify.Descriptor;
			}
		}

		// Token: 0x06017FFD RID: 98301 RVA: 0x0037DEEA File Offset: 0x0037C0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayOpenTimeNotify()
		{
		}

		// Token: 0x06017FFE RID: 98302 RVA: 0x0037DEF2 File Offset: 0x0037C0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayOpenTimeNotify(SceneGamePlayOpenTimeNotify other) : this()
		{
			this.gamePlayId_ = other.gamePlayId_;
			this.openTime_ = other.openTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017FFF RID: 98303 RVA: 0x0037DF23 File Offset: 0x0037C123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayOpenTimeNotify Clone()
		{
			return new SceneGamePlayOpenTimeNotify(this);
		}

		// Token: 0x170050CB RID: 20683
		// (get) Token: 0x06018000 RID: 98304 RVA: 0x0037DF2B File Offset: 0x0037C12B
		// (set) Token: 0x06018001 RID: 98305 RVA: 0x0037DF33 File Offset: 0x0037C133
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

		// Token: 0x170050CC RID: 20684
		// (get) Token: 0x06018002 RID: 98306 RVA: 0x0037DF3C File Offset: 0x0037C13C
		// (set) Token: 0x06018003 RID: 98307 RVA: 0x0037DF44 File Offset: 0x0037C144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x06018004 RID: 98308 RVA: 0x0037DF4D File Offset: 0x0037C14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayOpenTimeNotify);
		}

		// Token: 0x06018005 RID: 98309 RVA: 0x0037DF5B File Offset: 0x0037C15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayOpenTimeNotify other)
		{
			return other != null && (other == this || (this.GamePlayId == other.GamePlayId && this.OpenTime == other.OpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018006 RID: 98310 RVA: 0x0037DF9C File Offset: 0x0037C19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this.OpenTime != 0U)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018007 RID: 98311 RVA: 0x0037DFF4 File Offset: 0x0037C1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018008 RID: 98312 RVA: 0x0037E001 File Offset: 0x0037C201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018009 RID: 98313 RVA: 0x0037E00C File Offset: 0x0037C20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpenTime != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.OpenTime);
			}
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.GamePlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601800A RID: 98314 RVA: 0x0037E068 File Offset: 0x0037C268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this.OpenTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OpenTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601800B RID: 98315 RVA: 0x0037E0C0 File Offset: 0x0037C2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayOpenTimeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			if (other.OpenTime != 0U)
			{
				this.OpenTime = other.OpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601800C RID: 98316 RVA: 0x0037E110 File Offset: 0x0037C310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601800D RID: 98317 RVA: 0x0037E11C File Offset: 0x0037C31C
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
				if (num != 16U)
				{
					if (num != 72U)
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
					this.OpenTime = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04008EEB RID: 36587
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EEC RID: 36588
		public const int GamePlayIdFieldNumber = 9;

		// Token: 0x04008EED RID: 36589
		private int gamePlayId_;

		// Token: 0x04008EEE RID: 36590
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x04008EEF RID: 36591
		private uint openTime_;
	}
}
