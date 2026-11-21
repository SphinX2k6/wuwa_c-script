using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001525 RID: 5413
	[NetMessage(EMessageId.UpdateWorldTeamPlayerFightInfoNotify)]
	public sealed class UpdateWorldTeamPlayerFightInfoNotify : IMessage<UpdateWorldTeamPlayerFightInfoNotify>, IMessage, IEquatable<UpdateWorldTeamPlayerFightInfoNotify>, IDeepCloneable<UpdateWorldTeamPlayerFightInfoNotify>, IBufferMessage
	{
		// Token: 0x0601CACC RID: 117452 RVA: 0x00427A8E File Offset: 0x00425C8E
		[NullableContext(1)]
		public static UpdateWorldTeamPlayerFightInfoNotify Create()
		{
			return new UpdateWorldTeamPlayerFightInfoNotify();
		}

		// Token: 0x170060FD RID: 24829
		// (get) Token: 0x0601CACD RID: 117453 RVA: 0x00427A95 File Offset: 0x00425C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060FE RID: 24830
		// (get) Token: 0x0601CACE RID: 117454 RVA: 0x00427A98 File Offset: 0x00425C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateWorldTeamPlayerFightInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601CACF RID: 117455 RVA: 0x00427A9F File Offset: 0x00425C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateWorldTeamPlayerFightInfoNotify()
		{
		}

		// Token: 0x0601CAD0 RID: 117456 RVA: 0x00427AA8 File Offset: 0x00425CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateWorldTeamPlayerFightInfoNotify(UpdateWorldTeamPlayerFightInfoNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.fightInfo_ = ((other.fightInfo_ != null) ? other.fightInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CAD1 RID: 117457 RVA: 0x00427AF4 File Offset: 0x00425CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateWorldTeamPlayerFightInfoNotify Clone()
		{
			return new UpdateWorldTeamPlayerFightInfoNotify(this);
		}

		// Token: 0x170060FF RID: 24831
		// (get) Token: 0x0601CAD2 RID: 117458 RVA: 0x00427AFC File Offset: 0x00425CFC
		// (set) Token: 0x0601CAD3 RID: 117459 RVA: 0x00427B04 File Offset: 0x00425D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17006100 RID: 24832
		// (get) Token: 0x0601CAD4 RID: 117460 RVA: 0x00427B0D File Offset: 0x00425D0D
		// (set) Token: 0x0601CAD5 RID: 117461 RVA: 0x00427B15 File Offset: 0x00425D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerFightInfo FightInfo
		{
			get
			{
				return this.fightInfo_;
			}
			set
			{
				this.fightInfo_ = value;
			}
		}

		// Token: 0x0601CAD6 RID: 117462 RVA: 0x00427B1E File Offset: 0x00425D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateWorldTeamPlayerFightInfoNotify);
		}

		// Token: 0x0601CAD7 RID: 117463 RVA: 0x00427B2C File Offset: 0x00425D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateWorldTeamPlayerFightInfoNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this.FightInfo, other.FightInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CAD8 RID: 117464 RVA: 0x00427B7C File Offset: 0x00425D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.fightInfo_ != null)
			{
				num ^= this.FightInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CAD9 RID: 117465 RVA: 0x00427BD1 File Offset: 0x00425DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CADA RID: 117466 RVA: 0x00427BDE File Offset: 0x00425DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CADB RID: 117467 RVA: 0x00427BE8 File Offset: 0x00425DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this.fightInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.FightInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CADC RID: 117468 RVA: 0x00427C44 File Offset: 0x00425E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.fightInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FightInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CADD RID: 117469 RVA: 0x00427C9C File Offset: 0x00425E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateWorldTeamPlayerFightInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.fightInfo_ != null)
			{
				if (this.fightInfo_ == null)
				{
					this.FightInfo = new WorldTeamPlayerFightInfo();
				}
				this.FightInfo.MergeFrom(other.FightInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CADE RID: 117470 RVA: 0x00427D04 File Offset: 0x00425F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CADF RID: 117471 RVA: 0x00427D10 File Offset: 0x00425F10
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
				if (num != 104U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.fightInfo_ == null)
						{
							this.FightInfo = new WorldTeamPlayerFightInfo();
						}
						input.ReadMessage(this.FightInfo);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A52A RID: 42282
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A52B RID: 42283
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x0400A52C RID: 42284
		private int playerId_;

		// Token: 0x0400A52D RID: 42285
		public const int FightInfoFieldNumber = 15;

		// Token: 0x0400A52E RID: 42286
		private WorldTeamPlayerFightInfo fightInfo_;
	}
}
