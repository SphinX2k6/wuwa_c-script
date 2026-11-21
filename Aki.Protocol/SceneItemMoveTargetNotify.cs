using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A5 RID: 4517
	[NetMessage(EMessageId.SceneItemMoveTargetNotify)]
	public sealed class SceneItemMoveTargetNotify : IMessage<SceneItemMoveTargetNotify>, IMessage, IEquatable<SceneItemMoveTargetNotify>, IDeepCloneable<SceneItemMoveTargetNotify>, IBufferMessage
	{
		// Token: 0x06018208 RID: 98824 RVA: 0x00383703 File Offset: 0x00381903
		[NullableContext(1)]
		public static SceneItemMoveTargetNotify Create()
		{
			return new SceneItemMoveTargetNotify();
		}

		// Token: 0x1700514C RID: 20812
		// (get) Token: 0x06018209 RID: 98825 RVA: 0x0038370A File Offset: 0x0038190A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700514D RID: 20813
		// (get) Token: 0x0601820A RID: 98826 RVA: 0x0038370D File Offset: 0x0038190D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveTargetNotify.Descriptor;
			}
		}

		// Token: 0x0601820B RID: 98827 RVA: 0x00383714 File Offset: 0x00381914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetNotify()
		{
		}

		// Token: 0x0601820C RID: 98828 RVA: 0x0038371C File Offset: 0x0038191C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetNotify(SceneItemMoveTargetNotify other) : this()
		{
			this.moveInfo_ = ((other.moveInfo_ != null) ? other.moveInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601820D RID: 98829 RVA: 0x00383751 File Offset: 0x00381951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetNotify Clone()
		{
			return new SceneItemMoveTargetNotify(this);
		}

		// Token: 0x1700514E RID: 20814
		// (get) Token: 0x0601820E RID: 98830 RVA: 0x00383759 File Offset: 0x00381959
		// (set) Token: 0x0601820F RID: 98831 RVA: 0x00383761 File Offset: 0x00381961
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

		// Token: 0x06018210 RID: 98832 RVA: 0x0038376A File Offset: 0x0038196A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveTargetNotify);
		}

		// Token: 0x06018211 RID: 98833 RVA: 0x00383778 File Offset: 0x00381978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveTargetNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MoveInfo, other.MoveInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018212 RID: 98834 RVA: 0x003837AC File Offset: 0x003819AC
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

		// Token: 0x06018213 RID: 98835 RVA: 0x003837E8 File Offset: 0x003819E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018214 RID: 98836 RVA: 0x003837F5 File Offset: 0x003819F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018215 RID: 98837 RVA: 0x003837FE File Offset: 0x003819FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.moveInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.MoveInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018216 RID: 98838 RVA: 0x00383830 File Offset: 0x00381A30
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

		// Token: 0x06018217 RID: 98839 RVA: 0x00383870 File Offset: 0x00381A70
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

		// Token: 0x06018218 RID: 98840 RVA: 0x003838C4 File Offset: 0x00381AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018219 RID: 98841 RVA: 0x003838D0 File Offset: 0x00381AD0
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
				if (num != 106U)
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

		// Token: 0x04008FA7 RID: 36775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FA8 RID: 36776
		public const int MoveInfoFieldNumber = 13;

		// Token: 0x04008FA9 RID: 36777
		private SceneItemMoveTargetInfo moveInfo_;
	}
}
