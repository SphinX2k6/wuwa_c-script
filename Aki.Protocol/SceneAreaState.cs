using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001141 RID: 4417
	public sealed class SceneAreaState : IMessage<SceneAreaState>, IMessage, IEquatable<SceneAreaState>, IDeepCloneable<SceneAreaState>, IBufferMessage
	{
		// Token: 0x060178D6 RID: 96470 RVA: 0x0036B737 File Offset: 0x00369937
		[NullableContext(1)]
		public static SceneAreaState Create()
		{
			return new SceneAreaState();
		}

		// Token: 0x17004F0A RID: 20234
		// (get) Token: 0x060178D7 RID: 96471 RVA: 0x0036B73E File Offset: 0x0036993E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneAreaState> Parser
		{
			get
			{
				return SceneAreaState._parser;
			}
		}

		// Token: 0x17004F0B RID: 20235
		// (get) Token: 0x060178D8 RID: 96472 RVA: 0x0036B745 File Offset: 0x00369945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F0C RID: 20236
		// (get) Token: 0x060178D9 RID: 96473 RVA: 0x0036B748 File Offset: 0x00369948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneAreaState.Descriptor;
			}
		}

		// Token: 0x060178DA RID: 96474 RVA: 0x0036B74F File Offset: 0x0036994F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaState()
		{
		}

		// Token: 0x060178DB RID: 96475 RVA: 0x0036B757 File Offset: 0x00369957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaState(SceneAreaState other) : this()
		{
			this.areaId_ = other.areaId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060178DC RID: 96476 RVA: 0x0036B788 File Offset: 0x00369988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaState Clone()
		{
			return new SceneAreaState(this);
		}

		// Token: 0x17004F0D RID: 20237
		// (get) Token: 0x060178DD RID: 96477 RVA: 0x0036B790 File Offset: 0x00369990
		// (set) Token: 0x060178DE RID: 96478 RVA: 0x0036B798 File Offset: 0x00369998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17004F0E RID: 20238
		// (get) Token: 0x060178DF RID: 96479 RVA: 0x0036B7A1 File Offset: 0x003699A1
		// (set) Token: 0x060178E0 RID: 96480 RVA: 0x0036B7A9 File Offset: 0x003699A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x060178E1 RID: 96481 RVA: 0x0036B7B2 File Offset: 0x003699B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneAreaState);
		}

		// Token: 0x060178E2 RID: 96482 RVA: 0x0036B7C0 File Offset: 0x003699C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneAreaState other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060178E3 RID: 96483 RVA: 0x0036B800 File Offset: 0x00369A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.State)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060178E4 RID: 96484 RVA: 0x0036B858 File Offset: 0x00369A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060178E5 RID: 96485 RVA: 0x0036B865 File Offset: 0x00369A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060178E6 RID: 96486 RVA: 0x0036B870 File Offset: 0x00369A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AreaId);
			}
			if (this.State)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060178E7 RID: 96487 RVA: 0x0036B8C8 File Offset: 0x00369AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this.State)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060178E8 RID: 96488 RVA: 0x0036B914 File Offset: 0x00369B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneAreaState other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			if (other.State)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060178E9 RID: 96489 RVA: 0x0036B964 File Offset: 0x00369B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060178EA RID: 96490 RVA: 0x0036B970 File Offset: 0x00369B70
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = input.ReadBool();
					}
				}
				else
				{
					this.AreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008BE2 RID: 35810
		private static readonly MessageParser<SceneAreaState> _parser = new MessageParser<SceneAreaState>(() => new SceneAreaState());

		// Token: 0x04008BE3 RID: 35811
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BE4 RID: 35812
		public const int AreaIdFieldNumber = 1;

		// Token: 0x04008BE5 RID: 35813
		private int areaId_;

		// Token: 0x04008BE6 RID: 35814
		public const int StateFieldNumber = 2;

		// Token: 0x04008BE7 RID: 35815
		private bool state_;
	}
}
