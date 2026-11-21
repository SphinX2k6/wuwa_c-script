using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C1 RID: 4545
	public sealed class SceneRoleInformation : IMessage<SceneRoleInformation>, IMessage, IEquatable<SceneRoleInformation>, IDeepCloneable<SceneRoleInformation>, IBufferMessage
	{
		// Token: 0x0601844B RID: 99403 RVA: 0x003887BD File Offset: 0x003869BD
		[NullableContext(1)]
		public static SceneRoleInformation Create()
		{
			return new SceneRoleInformation();
		}

		// Token: 0x170051C6 RID: 20934
		// (get) Token: 0x0601844C RID: 99404 RVA: 0x003887C4 File Offset: 0x003869C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneRoleInformation> Parser
		{
			get
			{
				return SceneRoleInformation._parser;
			}
		}

		// Token: 0x170051C7 RID: 20935
		// (get) Token: 0x0601844D RID: 99405 RVA: 0x003887CB File Offset: 0x003869CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051C8 RID: 20936
		// (get) Token: 0x0601844E RID: 99406 RVA: 0x003887CE File Offset: 0x003869CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneRoleInformation.Descriptor;
			}
		}

		// Token: 0x0601844F RID: 99407 RVA: 0x003887D5 File Offset: 0x003869D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoleInformation()
		{
		}

		// Token: 0x06018450 RID: 99408 RVA: 0x003887DD File Offset: 0x003869DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoleInformation(SceneRoleInformation other) : this()
		{
			this.roleId_ = other.roleId_;
			this.entityId_ = other.entityId_;
			this.onStageOutOfControl_ = other.onStageOutOfControl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018451 RID: 99409 RVA: 0x0038881A File Offset: 0x00386A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoleInformation Clone()
		{
			return new SceneRoleInformation(this);
		}

		// Token: 0x170051C9 RID: 20937
		// (get) Token: 0x06018452 RID: 99410 RVA: 0x00388822 File Offset: 0x00386A22
		// (set) Token: 0x06018453 RID: 99411 RVA: 0x0038882A File Offset: 0x00386A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x170051CA RID: 20938
		// (get) Token: 0x06018454 RID: 99412 RVA: 0x00388833 File Offset: 0x00386A33
		// (set) Token: 0x06018455 RID: 99413 RVA: 0x0038883B File Offset: 0x00386A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170051CB RID: 20939
		// (get) Token: 0x06018456 RID: 99414 RVA: 0x00388844 File Offset: 0x00386A44
		// (set) Token: 0x06018457 RID: 99415 RVA: 0x0038884C File Offset: 0x00386A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OnStageOutOfControl
		{
			get
			{
				return this.onStageOutOfControl_;
			}
			set
			{
				this.onStageOutOfControl_ = value;
			}
		}

		// Token: 0x06018458 RID: 99416 RVA: 0x00388855 File Offset: 0x00386A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneRoleInformation);
		}

		// Token: 0x06018459 RID: 99417 RVA: 0x00388864 File Offset: 0x00386A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneRoleInformation other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.EntityId == other.EntityId && this.OnStageOutOfControl == other.OnStageOutOfControl && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601845A RID: 99418 RVA: 0x003888C0 File Offset: 0x00386AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.OnStageOutOfControl)
			{
				num ^= this.OnStageOutOfControl.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601845B RID: 99419 RVA: 0x00388931 File Offset: 0x00386B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601845C RID: 99420 RVA: 0x0038893E File Offset: 0x00386B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601845D RID: 99421 RVA: 0x00388948 File Offset: 0x00386B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.OnStageOutOfControl)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.OnStageOutOfControl);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601845E RID: 99422 RVA: 0x003889BC File Offset: 0x00386BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.OnStageOutOfControl)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601845F RID: 99423 RVA: 0x00388A20 File Offset: 0x00386C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneRoleInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.OnStageOutOfControl)
			{
				this.OnStageOutOfControl = other.OnStageOutOfControl;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018460 RID: 99424 RVA: 0x00388A84 File Offset: 0x00386C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018461 RID: 99425 RVA: 0x00388A90 File Offset: 0x00386C90
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.OnStageOutOfControl = input.ReadBool();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009047 RID: 36935
		private static readonly MessageParser<SceneRoleInformation> _parser = new MessageParser<SceneRoleInformation>(() => new SceneRoleInformation());

		// Token: 0x04009048 RID: 36936
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009049 RID: 36937
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400904A RID: 36938
		private int roleId_;

		// Token: 0x0400904B RID: 36939
		public const int EntityIdFieldNumber = 2;

		// Token: 0x0400904C RID: 36940
		private long entityId_;

		// Token: 0x0400904D RID: 36941
		public const int OnStageOutOfControlFieldNumber = 3;

		// Token: 0x0400904E RID: 36942
		private bool onStageOutOfControl_;
	}
}
