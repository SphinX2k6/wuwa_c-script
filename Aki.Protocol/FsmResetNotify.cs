using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065C RID: 1628
	[NetMessage(EMessageId.FsmResetNotify)]
	public sealed class FsmResetNotify : IMessage<FsmResetNotify>, IMessage, IEquatable<FsmResetNotify>, IDeepCloneable<FsmResetNotify>, IBufferMessage
	{
		// Token: 0x060095CD RID: 38349 RVA: 0x00169EFD File Offset: 0x001680FD
		[NullableContext(1)]
		public static FsmResetNotify Create()
		{
			return new FsmResetNotify();
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x060095CE RID: 38350 RVA: 0x00169F04 File Offset: 0x00168104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x060095CF RID: 38351 RVA: 0x00169F07 File Offset: 0x00168107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmResetNotify.Descriptor;
			}
		}

		// Token: 0x060095D0 RID: 38352 RVA: 0x00169F0E File Offset: 0x0016810E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmResetNotify()
		{
		}

		// Token: 0x060095D1 RID: 38353 RVA: 0x00169F16 File Offset: 0x00168116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmResetNotify(FsmResetNotify other) : this()
		{
			this.entityFsmComponentPb_ = ((other.entityFsmComponentPb_ != null) ? other.entityFsmComponentPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095D2 RID: 38354 RVA: 0x00169F4B File Offset: 0x0016814B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmResetNotify Clone()
		{
			return new FsmResetNotify(this);
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x060095D3 RID: 38355 RVA: 0x00169F53 File Offset: 0x00168153
		// (set) Token: 0x060095D4 RID: 38356 RVA: 0x00169F5B File Offset: 0x0016815B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFsmComponentPb EntityFsmComponentPb
		{
			get
			{
				return this.entityFsmComponentPb_;
			}
			set
			{
				this.entityFsmComponentPb_ = value;
			}
		}

		// Token: 0x060095D5 RID: 38357 RVA: 0x00169F64 File Offset: 0x00168164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmResetNotify);
		}

		// Token: 0x060095D6 RID: 38358 RVA: 0x00169F72 File Offset: 0x00168172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmResetNotify other)
		{
			return other != null && (other == this || (object.Equals(this.EntityFsmComponentPb, other.EntityFsmComponentPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095D7 RID: 38359 RVA: 0x00169FA8 File Offset: 0x001681A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityFsmComponentPb_ != null)
			{
				num ^= this.EntityFsmComponentPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095D8 RID: 38360 RVA: 0x00169FE4 File Offset: 0x001681E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060095D9 RID: 38361 RVA: 0x00169FF1 File Offset: 0x001681F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095DA RID: 38362 RVA: 0x00169FFA File Offset: 0x001681FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityFsmComponentPb_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.EntityFsmComponentPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095DB RID: 38363 RVA: 0x0016A02C File Offset: 0x0016822C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityFsmComponentPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityFsmComponentPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095DC RID: 38364 RVA: 0x0016A06C File Offset: 0x0016826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmResetNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityFsmComponentPb_ != null)
			{
				if (this.entityFsmComponentPb_ == null)
				{
					this.EntityFsmComponentPb = new EntityFsmComponentPb();
				}
				this.EntityFsmComponentPb.MergeFrom(other.EntityFsmComponentPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x0016A0C0 File Offset: 0x001682C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095DE RID: 38366 RVA: 0x0016A0CC File Offset: 0x001682CC
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.entityFsmComponentPb_ == null)
					{
						this.EntityFsmComponentPb = new EntityFsmComponentPb();
					}
					input.ReadMessage(this.EntityFsmComponentPb);
				}
			}
		}

		// Token: 0x040047E0 RID: 18400
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047E1 RID: 18401
		public const int EntityFsmComponentPbFieldNumber = 14;

		// Token: 0x040047E2 RID: 18402
		private EntityFsmComponentPb entityFsmComponentPb_;
	}
}
