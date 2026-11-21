using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A0 RID: 4512
	public sealed class SceneItemLifeCycleComponentDestroyCtxPb : IMessage<SceneItemLifeCycleComponentDestroyCtxPb>, IMessage, IEquatable<SceneItemLifeCycleComponentDestroyCtxPb>, IDeepCloneable<SceneItemLifeCycleComponentDestroyCtxPb>, IBufferMessage
	{
		// Token: 0x0601819C RID: 98716 RVA: 0x00382638 File Offset: 0x00380838
		[NullableContext(1)]
		public static SceneItemLifeCycleComponentDestroyCtxPb Create()
		{
			return new SceneItemLifeCycleComponentDestroyCtxPb();
		}

		// Token: 0x17005134 RID: 20788
		// (get) Token: 0x0601819D RID: 98717 RVA: 0x0038263F File Offset: 0x0038083F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005135 RID: 20789
		// (get) Token: 0x0601819E RID: 98718 RVA: 0x00382642 File Offset: 0x00380842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemLifeCycleComponentDestroyCtxPb.Descriptor;
			}
		}

		// Token: 0x0601819F RID: 98719 RVA: 0x00382649 File Offset: 0x00380849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentDestroyCtxPb()
		{
		}

		// Token: 0x060181A0 RID: 98720 RVA: 0x00382651 File Offset: 0x00380851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentDestroyCtxPb(SceneItemLifeCycleComponentDestroyCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060181A1 RID: 98721 RVA: 0x00382686 File Offset: 0x00380886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentDestroyCtxPb Clone()
		{
			return new SceneItemLifeCycleComponentDestroyCtxPb(this);
		}

		// Token: 0x17005136 RID: 20790
		// (get) Token: 0x060181A2 RID: 98722 RVA: 0x0038268E File Offset: 0x0038088E
		// (set) Token: 0x060181A3 RID: 98723 RVA: 0x00382696 File Offset: 0x00380896
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

		// Token: 0x060181A4 RID: 98724 RVA: 0x0038269F File Offset: 0x0038089F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemLifeCycleComponentDestroyCtxPb);
		}

		// Token: 0x060181A5 RID: 98725 RVA: 0x003826AD File Offset: 0x003808AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemLifeCycleComponentDestroyCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060181A6 RID: 98726 RVA: 0x003826E0 File Offset: 0x003808E0
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

		// Token: 0x060181A7 RID: 98727 RVA: 0x0038271C File Offset: 0x0038091C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060181A8 RID: 98728 RVA: 0x00382729 File Offset: 0x00380929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060181A9 RID: 98729 RVA: 0x00382732 File Offset: 0x00380932
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

		// Token: 0x060181AA RID: 98730 RVA: 0x00382764 File Offset: 0x00380964
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

		// Token: 0x060181AB RID: 98731 RVA: 0x003827A4 File Offset: 0x003809A4
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

		// Token: 0x060181AC RID: 98732 RVA: 0x003827F8 File Offset: 0x003809F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060181AD RID: 98733 RVA: 0x00382804 File Offset: 0x00380A04
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

		// Token: 0x04008F86 RID: 36742
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F87 RID: 36743
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04008F88 RID: 36744
		private EntityCtxPb entityCtx_;
	}
}
