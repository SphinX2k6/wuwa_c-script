using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001165 RID: 4453
	public sealed class SceneItemLifeCycleComponentCreateCtxPb : IMessage<SceneItemLifeCycleComponentCreateCtxPb>, IMessage, IEquatable<SceneItemLifeCycleComponentCreateCtxPb>, IDeepCloneable<SceneItemLifeCycleComponentCreateCtxPb>, IBufferMessage
	{
		// Token: 0x06017BE9 RID: 97257 RVA: 0x003730C4 File Offset: 0x003712C4
		[NullableContext(1)]
		public static SceneItemLifeCycleComponentCreateCtxPb Create()
		{
			return new SceneItemLifeCycleComponentCreateCtxPb();
		}

		// Token: 0x17004FC5 RID: 20421
		// (get) Token: 0x06017BEA RID: 97258 RVA: 0x003730CB File Offset: 0x003712CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FC6 RID: 20422
		// (get) Token: 0x06017BEB RID: 97259 RVA: 0x003730CE File Offset: 0x003712CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemLifeCycleComponentCreateCtxPb.Descriptor;
			}
		}

		// Token: 0x06017BEC RID: 97260 RVA: 0x003730D5 File Offset: 0x003712D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentCreateCtxPb()
		{
		}

		// Token: 0x06017BED RID: 97261 RVA: 0x003730DD File Offset: 0x003712DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentCreateCtxPb(SceneItemLifeCycleComponentCreateCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017BEE RID: 97262 RVA: 0x00373112 File Offset: 0x00371312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentCreateCtxPb Clone()
		{
			return new SceneItemLifeCycleComponentCreateCtxPb(this);
		}

		// Token: 0x17004FC7 RID: 20423
		// (get) Token: 0x06017BEF RID: 97263 RVA: 0x0037311A File Offset: 0x0037131A
		// (set) Token: 0x06017BF0 RID: 97264 RVA: 0x00373122 File Offset: 0x00371322
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

		// Token: 0x06017BF1 RID: 97265 RVA: 0x0037312B File Offset: 0x0037132B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemLifeCycleComponentCreateCtxPb);
		}

		// Token: 0x06017BF2 RID: 97266 RVA: 0x00373139 File Offset: 0x00371339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemLifeCycleComponentCreateCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017BF3 RID: 97267 RVA: 0x0037316C File Offset: 0x0037136C
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

		// Token: 0x06017BF4 RID: 97268 RVA: 0x003731A8 File Offset: 0x003713A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017BF5 RID: 97269 RVA: 0x003731B5 File Offset: 0x003713B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017BF6 RID: 97270 RVA: 0x003731BE File Offset: 0x003713BE
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

		// Token: 0x06017BF7 RID: 97271 RVA: 0x003731F0 File Offset: 0x003713F0
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

		// Token: 0x06017BF8 RID: 97272 RVA: 0x00373230 File Offset: 0x00371430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemLifeCycleComponentCreateCtxPb other)
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

		// Token: 0x06017BF9 RID: 97273 RVA: 0x00373284 File Offset: 0x00371484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017BFA RID: 97274 RVA: 0x00373290 File Offset: 0x00371490
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

		// Token: 0x04008CF0 RID: 36080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CF1 RID: 36081
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04008CF2 RID: 36082
		private EntityCtxPb entityCtx_;
	}
}
