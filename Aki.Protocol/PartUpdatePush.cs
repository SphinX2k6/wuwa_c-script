using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC8 RID: 3016
	[NetMessage(EMessageId.PartUpdatePush)]
	public sealed class PartUpdatePush : IMessage<PartUpdatePush>, IMessage, IEquatable<PartUpdatePush>, IDeepCloneable<PartUpdatePush>, IBufferMessage
	{
		// Token: 0x06010573 RID: 66931 RVA: 0x002623E0 File Offset: 0x002605E0
		[NullableContext(1)]
		public static PartUpdatePush Create()
		{
			return new PartUpdatePush();
		}

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x06010574 RID: 66932 RVA: 0x002623E7 File Offset: 0x002605E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x06010575 RID: 66933 RVA: 0x002623EA File Offset: 0x002605EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartUpdatePush.Descriptor;
			}
		}

		// Token: 0x06010576 RID: 66934 RVA: 0x002623F1 File Offset: 0x002605F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdatePush()
		{
		}

		// Token: 0x06010577 RID: 66935 RVA: 0x00262404 File Offset: 0x00260604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdatePush(PartUpdatePush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.partUpdateInfos_ = other.partUpdateInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010578 RID: 66936 RVA: 0x0026243A File Offset: 0x0026063A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdatePush Clone()
		{
			return new PartUpdatePush(this);
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x06010579 RID: 66937 RVA: 0x00262442 File Offset: 0x00260642
		// (set) Token: 0x0601057A RID: 66938 RVA: 0x0026244A File Offset: 0x0026064A
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

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0601057B RID: 66939 RVA: 0x00262453 File Offset: 0x00260653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartUpdateInfo> PartUpdateInfos
		{
			get
			{
				return this.partUpdateInfos_;
			}
		}

		// Token: 0x0601057C RID: 66940 RVA: 0x0026245B File Offset: 0x0026065B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartUpdatePush);
		}

		// Token: 0x0601057D RID: 66941 RVA: 0x0026246C File Offset: 0x0026066C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartUpdatePush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.partUpdateInfos_.Equals(other.partUpdateInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601057E RID: 66942 RVA: 0x002624BC File Offset: 0x002606BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.partUpdateInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601057F RID: 66943 RVA: 0x00262509 File Offset: 0x00260709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010580 RID: 66944 RVA: 0x00262516 File Offset: 0x00260716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010581 RID: 66945 RVA: 0x00262520 File Offset: 0x00260720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			this.partUpdateInfos_.WriteTo(ref output, PartUpdatePush._repeated_partUpdateInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010582 RID: 66946 RVA: 0x00262570 File Offset: 0x00260770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.partUpdateInfos_.CalculateSize(PartUpdatePush._repeated_partUpdateInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010583 RID: 66947 RVA: 0x002625C4 File Offset: 0x002607C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartUpdatePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.partUpdateInfos_.Add(other.partUpdateInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010584 RID: 66948 RVA: 0x00262611 File Offset: 0x00260811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010585 RID: 66949 RVA: 0x0026261C File Offset: 0x0026081C
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
				if (num != 16U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.partUpdateInfos_.AddEntriesFrom(ref input, PartUpdatePush._repeated_partUpdateInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040067CF RID: 26575
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067D0 RID: 26576
		public const int EntityIdFieldNumber = 2;

		// Token: 0x040067D1 RID: 26577
		private long entityId_;

		// Token: 0x040067D2 RID: 26578
		public const int PartUpdateInfosFieldNumber = 7;

		// Token: 0x040067D3 RID: 26579
		private static readonly FieldCodec<PartUpdateInfo> _repeated_partUpdateInfos_codec = FieldCodec.ForMessage<PartUpdateInfo>(58U, PartUpdateInfo.Parser);

		// Token: 0x040067D4 RID: 26580
		private readonly RepeatedField<PartUpdateInfo> partUpdateInfos_ = new RepeatedField<PartUpdateInfo>();
	}
}
