using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000184 RID: 388
	public sealed class BeamCastHitPlayerActionCtxPb : IMessage<BeamCastHitPlayerActionCtxPb>, IMessage, IEquatable<BeamCastHitPlayerActionCtxPb>, IDeepCloneable<BeamCastHitPlayerActionCtxPb>, IBufferMessage
	{
		// Token: 0x06002F0E RID: 12046 RVA: 0x000791BD File Offset: 0x000773BD
		[NullableContext(1)]
		public static BeamCastHitPlayerActionCtxPb Create()
		{
			return new BeamCastHitPlayerActionCtxPb();
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x000791C4 File Offset: 0x000773C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002F10 RID: 12048 RVA: 0x000791C7 File Offset: 0x000773C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeamCastHitPlayerActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x000791CE File Offset: 0x000773CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerActionCtxPb()
		{
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x000791D6 File Offset: 0x000773D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerActionCtxPb(BeamCastHitPlayerActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x0007920B File Offset: 0x0007740B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerActionCtxPb Clone()
		{
			return new BeamCastHitPlayerActionCtxPb(this);
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06002F14 RID: 12052 RVA: 0x00079213 File Offset: 0x00077413
		// (set) Token: 0x06002F15 RID: 12053 RVA: 0x0007921B File Offset: 0x0007741B
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

		// Token: 0x06002F16 RID: 12054 RVA: 0x00079224 File Offset: 0x00077424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeamCastHitPlayerActionCtxPb);
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00079232 File Offset: 0x00077432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeamCastHitPlayerActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00079268 File Offset: 0x00077468
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

		// Token: 0x06002F19 RID: 12057 RVA: 0x000792A4 File Offset: 0x000774A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x000792B1 File Offset: 0x000774B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x000792BA File Offset: 0x000774BA
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

		// Token: 0x06002F1C RID: 12060 RVA: 0x000792EC File Offset: 0x000774EC
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

		// Token: 0x06002F1D RID: 12061 RVA: 0x0007932C File Offset: 0x0007752C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeamCastHitPlayerActionCtxPb other)
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

		// Token: 0x06002F1E RID: 12062 RVA: 0x00079380 File Offset: 0x00077580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x0007938C File Offset: 0x0007758C
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

		// Token: 0x040028F1 RID: 10481
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028F2 RID: 10482
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040028F3 RID: 10483
		private EntityCtxPb entityCtx_;
	}
}
