using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A2 RID: 162
	[NetMessage(EMessageId.AddDecalRequest)]
	public sealed class AddDecalRequest : IMessage<AddDecalRequest>, IMessage, IEquatable<AddDecalRequest>, IDeepCloneable<AddDecalRequest>, IBufferMessage
	{
		// Token: 0x06001C9E RID: 7326 RVA: 0x0004F682 File Offset: 0x0004D882
		[NullableContext(1)]
		public static AddDecalRequest Create()
		{
			return new AddDecalRequest();
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x0004F689 File Offset: 0x0004D889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x0004F68C File Offset: 0x0004D88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddDecalRequest.Descriptor;
			}
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0004F693 File Offset: 0x0004D893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalRequest()
		{
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0004F69C File Offset: 0x0004D89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalRequest(AddDecalRequest other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this.position_ = ((other.position_ != null) ? other.position_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.effectId_ = other.effectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0004F710 File Offset: 0x0004D910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalRequest Clone()
		{
			return new AddDecalRequest(this);
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x0004F718 File Offset: 0x0004D918
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x0004F720 File Offset: 0x0004D920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneId
		{
			get
			{
				return this.sceneId_;
			}
			set
			{
				this.sceneId_ = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0004F729 File Offset: 0x0004D929
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0004F731 File Offset: 0x0004D931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Position
		{
			get
			{
				return this.position_;
			}
			set
			{
				this.position_ = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x0004F73A File Offset: 0x0004D93A
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x0004F742 File Offset: 0x0004D942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x0004F74B File Offset: 0x0004D94B
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x0004F753 File Offset: 0x0004D953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectId
		{
			get
			{
				return this.effectId_;
			}
			set
			{
				this.effectId_ = value;
			}
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0004F75C File Offset: 0x0004D95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddDecalRequest);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0004F76C File Offset: 0x0004D96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddDecalRequest other)
		{
			return other != null && (other == this || (this.SceneId == other.SceneId && object.Equals(this.Position, other.Position) && object.Equals(this.Rotation, other.Rotation) && this.EffectId == other.EffectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0004F7E0 File Offset: 0x0004D9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneId != 0)
			{
				num ^= this.SceneId.GetHashCode();
			}
			if (this.position_ != null)
			{
				num ^= this.Position.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.EffectId != 0)
			{
				num ^= this.EffectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0004F864 File Offset: 0x0004DA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0004F871 File Offset: 0x0004DA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0004F87C File Offset: 0x0004DA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EffectId);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Rotation);
			}
			if (this.SceneId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SceneId);
			}
			if (this.position_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Position);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0004F910 File Offset: 0x0004DB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneId);
			}
			if (this.position_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Position);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.EffectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0004F998 File Offset: 0x0004DB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddDecalRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneId != 0)
			{
				this.SceneId = other.SceneId;
			}
			if (other.position_ != null)
			{
				if (this.position_ == null)
				{
					this.Position = new Vector();
				}
				this.Position.MergeFrom(other.Position);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Vector();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			if (other.EffectId != 0)
			{
				this.EffectId = other.EffectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0004FA40 File Offset: 0x0004DC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0004FA4C File Offset: 0x0004DC4C
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
				if (num <= 42U)
				{
					if (num == 16U)
					{
						this.EffectId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Vector();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.SceneId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.position_ == null)
						{
							this.Position = new Vector();
						}
						input.ReadMessage(this.Position);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002338 RID: 9016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002339 RID: 9017
		public const int SceneIdFieldNumber = 7;

		// Token: 0x0400233A RID: 9018
		private int sceneId_;

		// Token: 0x0400233B RID: 9019
		public const int PositionFieldNumber = 14;

		// Token: 0x0400233C RID: 9020
		private Vector position_;

		// Token: 0x0400233D RID: 9021
		public const int RotationFieldNumber = 5;

		// Token: 0x0400233E RID: 9022
		private Vector rotation_;

		// Token: 0x0400233F RID: 9023
		public const int EffectIdFieldNumber = 2;

		// Token: 0x04002340 RID: 9024
		private int effectId_;
	}
}
