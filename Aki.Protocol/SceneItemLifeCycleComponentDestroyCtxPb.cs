using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001166 RID: 4454
	public sealed class SceneItemLifeCycleComponentDestroyCtxPb : IMessage<SceneItemLifeCycleComponentDestroyCtxPb>, IMessage, IEquatable<SceneItemLifeCycleComponentDestroyCtxPb>, IDeepCloneable<SceneItemLifeCycleComponentDestroyCtxPb>, IBufferMessage
	{
		// Token: 0x06017BFB RID: 97275 RVA: 0x003732E8 File Offset: 0x003714E8
		[NullableContext(1)]
		public static SceneItemLifeCycleComponentDestroyCtxPb Create()
		{
			return new SceneItemLifeCycleComponentDestroyCtxPb();
		}

		// Token: 0x17004FC8 RID: 20424
		// (get) Token: 0x06017BFC RID: 97276 RVA: 0x003732EF File Offset: 0x003714EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FC9 RID: 20425
		// (get) Token: 0x06017BFD RID: 97277 RVA: 0x003732F2 File Offset: 0x003714F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemLifeCycleComponentDestroyCtxPb.Descriptor;
			}
		}

		// Token: 0x06017BFE RID: 97278 RVA: 0x003732F9 File Offset: 0x003714F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentDestroyCtxPb()
		{
		}

		// Token: 0x06017BFF RID: 97279 RVA: 0x00373301 File Offset: 0x00371501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentDestroyCtxPb(SceneItemLifeCycleComponentDestroyCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C00 RID: 97280 RVA: 0x00373336 File Offset: 0x00371536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentDestroyCtxPb Clone()
		{
			return new SceneItemLifeCycleComponentDestroyCtxPb(this);
		}

		// Token: 0x17004FCA RID: 20426
		// (get) Token: 0x06017C01 RID: 97281 RVA: 0x0037333E File Offset: 0x0037153E
		// (set) Token: 0x06017C02 RID: 97282 RVA: 0x00373346 File Offset: 0x00371546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x06017C03 RID: 97283 RVA: 0x0037334F File Offset: 0x0037154F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemLifeCycleComponentDestroyCtxPb);
		}

		// Token: 0x06017C04 RID: 97284 RVA: 0x0037335D File Offset: 0x0037155D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemLifeCycleComponentDestroyCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C05 RID: 97285 RVA: 0x00373390 File Offset: 0x00371590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017C06 RID: 97286 RVA: 0x003733CC File Offset: 0x003715CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C07 RID: 97287 RVA: 0x003733D9 File Offset: 0x003715D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C08 RID: 97288 RVA: 0x003733E2 File Offset: 0x003715E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017C09 RID: 97289 RVA: 0x00373414 File Offset: 0x00371614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017C0A RID: 97290 RVA: 0x00373454 File Offset: 0x00371654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemLifeCycleComponentDestroyCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017C0B RID: 97291 RVA: 0x003734A8 File Offset: 0x003716A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C0C RID: 97292 RVA: 0x003734B4 File Offset: 0x003716B4
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04008CF3 RID: 36083
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CF4 RID: 36084
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04008CF5 RID: 36085
		private EntityCtxPb entityCtx_;
	}
}
