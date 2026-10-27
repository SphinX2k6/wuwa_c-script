using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116B RID: 4459
	[NetMessage(EMessageId.SceneItemMoveTargetNotify)]
	public sealed class SceneItemMoveTargetNotify : IMessage<SceneItemMoveTargetNotify>, IMessage, IEquatable<SceneItemMoveTargetNotify>, IDeepCloneable<SceneItemMoveTargetNotify>, IBufferMessage
	{
		// Token: 0x06017C67 RID: 97383 RVA: 0x003743B3 File Offset: 0x003725B3
		[NullableContext(1)]
		public static SceneItemMoveTargetNotify Create()
		{
			return new SceneItemMoveTargetNotify();
		}

		// Token: 0x17004FE0 RID: 20448
		// (get) Token: 0x06017C68 RID: 97384 RVA: 0x003743BA File Offset: 0x003725BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FE1 RID: 20449
		// (get) Token: 0x06017C69 RID: 97385 RVA: 0x003743BD File Offset: 0x003725BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveTargetNotify.Descriptor;
			}
		}

		// Token: 0x06017C6A RID: 97386 RVA: 0x003743C4 File Offset: 0x003725C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetNotify()
		{
		}

		// Token: 0x06017C6B RID: 97387 RVA: 0x003743CC File Offset: 0x003725CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetNotify(SceneItemMoveTargetNotify other) : this()
		{
			this.moveInfo_ = ((other.moveInfo_ != null) ? other.moveInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C6C RID: 97388 RVA: 0x00374401 File Offset: 0x00372601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetNotify Clone()
		{
			return new SceneItemMoveTargetNotify(this);
		}

		// Token: 0x17004FE2 RID: 20450
		// (get) Token: 0x06017C6D RID: 97389 RVA: 0x00374409 File Offset: 0x00372609
		// (set) Token: 0x06017C6E RID: 97390 RVA: 0x00374411 File Offset: 0x00372611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetInfo MoveInfo
		{
			get
			{
				return this.moveInfo_;
			}
			set
			{
				this.moveInfo_ = value;
			}
		}

		// Token: 0x06017C6F RID: 97391 RVA: 0x0037441A File Offset: 0x0037261A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveTargetNotify);
		}

		// Token: 0x06017C70 RID: 97392 RVA: 0x00374428 File Offset: 0x00372628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveTargetNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MoveInfo, other.MoveInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C71 RID: 97393 RVA: 0x0037445C File Offset: 0x0037265C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.moveInfo_ != null)
			{
				num ^= this.MoveInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017C72 RID: 97394 RVA: 0x00374498 File Offset: 0x00372698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C73 RID: 97395 RVA: 0x003744A5 File Offset: 0x003726A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C74 RID: 97396 RVA: 0x003744AE File Offset: 0x003726AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.moveInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MoveInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017C75 RID: 97397 RVA: 0x003744E0 File Offset: 0x003726E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.moveInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017C76 RID: 97398 RVA: 0x00374520 File Offset: 0x00372720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemMoveTargetNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.moveInfo_ != null)
			{
				if (this.moveInfo_ == null)
				{
					this.MoveInfo = new SceneItemMoveTargetInfo();
				}
				this.MoveInfo.MergeFrom(other.MoveInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017C77 RID: 97399 RVA: 0x00374574 File Offset: 0x00372774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C78 RID: 97400 RVA: 0x00374580 File Offset: 0x00372780
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.moveInfo_ == null)
					{
						this.MoveInfo = new SceneItemMoveTargetInfo();
					}
					input.ReadMessage(this.MoveInfo);
				}
			}
		}

		// Token: 0x04008D14 RID: 36116
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D15 RID: 36117
		public const int MoveInfoFieldNumber = 10;

		// Token: 0x04008D16 RID: 36118
		private SceneItemMoveTargetInfo moveInfo_;
	}
}
