using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116C RID: 4460
	[NetMessage(EMessageId.SceneItemMoveTargetRequest)]
	public sealed class SceneItemMoveTargetRequest : IMessage<SceneItemMoveTargetRequest>, IMessage, IEquatable<SceneItemMoveTargetRequest>, IDeepCloneable<SceneItemMoveTargetRequest>, IBufferMessage
	{
		// Token: 0x06017C79 RID: 97401 RVA: 0x003745D8 File Offset: 0x003727D8
		[NullableContext(1)]
		public static SceneItemMoveTargetRequest Create()
		{
			return new SceneItemMoveTargetRequest();
		}

		// Token: 0x17004FE3 RID: 20451
		// (get) Token: 0x06017C7A RID: 97402 RVA: 0x003745DF File Offset: 0x003727DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FE4 RID: 20452
		// (get) Token: 0x06017C7B RID: 97403 RVA: 0x003745E2 File Offset: 0x003727E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveTargetRequest.Descriptor;
			}
		}

		// Token: 0x06017C7C RID: 97404 RVA: 0x003745E9 File Offset: 0x003727E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetRequest()
		{
		}

		// Token: 0x06017C7D RID: 97405 RVA: 0x003745F4 File Offset: 0x003727F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetRequest(SceneItemMoveTargetRequest other) : this()
		{
			this.moveInfo_ = ((other.moveInfo_ != null) ? other.moveInfo_.Clone() : null);
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C7E RID: 97406 RVA: 0x00374640 File Offset: 0x00372840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetRequest Clone()
		{
			return new SceneItemMoveTargetRequest(this);
		}

		// Token: 0x17004FE5 RID: 20453
		// (get) Token: 0x06017C7F RID: 97407 RVA: 0x00374648 File Offset: 0x00372848
		// (set) Token: 0x06017C80 RID: 97408 RVA: 0x00374650 File Offset: 0x00372850
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

		// Token: 0x17004FE6 RID: 20454
		// (get) Token: 0x06017C81 RID: 97409 RVA: 0x00374659 File Offset: 0x00372859
		// (set) Token: 0x06017C82 RID: 97410 RVA: 0x00374661 File Offset: 0x00372861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneOwnerId
		{
			get
			{
				return this.sceneOwnerId_;
			}
			set
			{
				this.sceneOwnerId_ = value;
			}
		}

		// Token: 0x06017C83 RID: 97411 RVA: 0x0037466A File Offset: 0x0037286A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveTargetRequest);
		}

		// Token: 0x06017C84 RID: 97412 RVA: 0x00374678 File Offset: 0x00372878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveTargetRequest other)
		{
			return other != null && (other == this || (object.Equals(this.MoveInfo, other.MoveInfo) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C85 RID: 97413 RVA: 0x003746C8 File Offset: 0x003728C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.moveInfo_ != null)
			{
				num ^= this.MoveInfo.GetHashCode();
			}
			if (this.SceneOwnerId != 0)
			{
				num ^= this.SceneOwnerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017C86 RID: 97414 RVA: 0x0037471D File Offset: 0x0037291D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C87 RID: 97415 RVA: 0x0037472A File Offset: 0x0037292A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C88 RID: 97416 RVA: 0x00374734 File Offset: 0x00372934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.moveInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MoveInfo);
			}
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017C89 RID: 97417 RVA: 0x00374790 File Offset: 0x00372990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.moveInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveInfo);
			}
			if (this.SceneOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017C8A RID: 97418 RVA: 0x003747E8 File Offset: 0x003729E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemMoveTargetRequest other)
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
			if (other.SceneOwnerId != 0)
			{
				this.SceneOwnerId = other.SceneOwnerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017C8B RID: 97419 RVA: 0x00374850 File Offset: 0x00372A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C8C RID: 97420 RVA: 0x0037485C File Offset: 0x00372A5C
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SceneOwnerId = input.ReadInt32();
					}
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

		// Token: 0x04008D17 RID: 36119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D18 RID: 36120
		public const int MoveInfoFieldNumber = 10;

		// Token: 0x04008D19 RID: 36121
		private SceneItemMoveTargetInfo moveInfo_;

		// Token: 0x04008D1A RID: 36122
		public const int SceneOwnerIdFieldNumber = 15;

		// Token: 0x04008D1B RID: 36123
		private int sceneOwnerId_;
	}
}
