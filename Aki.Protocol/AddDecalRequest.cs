using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A1 RID: 161
	[NetMessage(EMessageId.AddDecalRequest)]
	public sealed class AddDecalRequest : IMessage<AddDecalRequest>, IMessage, IEquatable<AddDecalRequest>, IDeepCloneable<AddDecalRequest>, IBufferMessage
	{
		// Token: 0x06001C57 RID: 7255 RVA: 0x0004EA72 File Offset: 0x0004CC72
		[NullableContext(1)]
		public static AddDecalRequest Create()
		{
			return new AddDecalRequest();
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x0004EA79 File Offset: 0x0004CC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0004EA7C File Offset: 0x0004CC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddDecalRequest.Descriptor;
			}
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0004EA83 File Offset: 0x0004CC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalRequest()
		{
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0004EA8C File Offset: 0x0004CC8C
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

		// Token: 0x06001C5C RID: 7260 RVA: 0x0004EB00 File Offset: 0x0004CD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalRequest Clone()
		{
			return new AddDecalRequest(this);
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x0004EB08 File Offset: 0x0004CD08
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x0004EB10 File Offset: 0x0004CD10
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0004EB19 File Offset: 0x0004CD19
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x0004EB21 File Offset: 0x0004CD21
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

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0004EB2A File Offset: 0x0004CD2A
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x0004EB32 File Offset: 0x0004CD32
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

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x0004EB3B File Offset: 0x0004CD3B
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x0004EB43 File Offset: 0x0004CD43
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

		// Token: 0x06001C65 RID: 7269 RVA: 0x0004EB4C File Offset: 0x0004CD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddDecalRequest);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0004EB5C File Offset: 0x0004CD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddDecalRequest other)
		{
			return other != null && (other == this || (this.SceneId == other.SceneId && object.Equals(this.Position, other.Position) && object.Equals(this.Rotation, other.Rotation) && this.EffectId == other.EffectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0004EBD0 File Offset: 0x0004CDD0
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

		// Token: 0x06001C68 RID: 7272 RVA: 0x0004EC54 File Offset: 0x0004CE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0004EC61 File Offset: 0x0004CE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0004EC6C File Offset: 0x0004CE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EffectId);
			}
			if (this.position_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Position);
			}
			if (this.SceneId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SceneId);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0004ED00 File Offset: 0x0004CF00
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

		// Token: 0x06001C6C RID: 7276 RVA: 0x0004ED88 File Offset: 0x0004CF88
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

		// Token: 0x06001C6D RID: 7277 RVA: 0x0004EE30 File Offset: 0x0004D030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0004EE3C File Offset: 0x0004D03C
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
					if (num == 24U)
					{
						this.EffectId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.position_ == null)
						{
							this.Position = new Vector();
						}
						input.ReadMessage(this.Position);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.SceneId = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Vector();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022D7 RID: 8919
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022D8 RID: 8920
		public const int SceneIdFieldNumber = 9;

		// Token: 0x040022D9 RID: 8921
		private int sceneId_;

		// Token: 0x040022DA RID: 8922
		public const int PositionFieldNumber = 5;

		// Token: 0x040022DB RID: 8923
		private Vector position_;

		// Token: 0x040022DC RID: 8924
		public const int RotationFieldNumber = 15;

		// Token: 0x040022DD RID: 8925
		private Vector rotation_;

		// Token: 0x040022DE RID: 8926
		public const int EffectIdFieldNumber = 3;

		// Token: 0x040022DF RID: 8927
		private int effectId_;
	}
}
