using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001523 RID: 5411
	[NetMessage(EMessageId.UpdateSysBuffNotify)]
	public sealed class UpdateSysBuffNotify : IMessage<UpdateSysBuffNotify>, IMessage, IEquatable<UpdateSysBuffNotify>, IDeepCloneable<UpdateSysBuffNotify>, IBufferMessage
	{
		// Token: 0x0601CAA2 RID: 117410 RVA: 0x00427451 File Offset: 0x00425651
		[NullableContext(1)]
		public static UpdateSysBuffNotify Create()
		{
			return new UpdateSysBuffNotify();
		}

		// Token: 0x170060F4 RID: 24820
		// (get) Token: 0x0601CAA3 RID: 117411 RVA: 0x00427458 File Offset: 0x00425658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060F5 RID: 24821
		// (get) Token: 0x0601CAA4 RID: 117412 RVA: 0x0042745B File Offset: 0x0042565B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSysBuffNotify.Descriptor;
			}
		}

		// Token: 0x0601CAA5 RID: 117413 RVA: 0x00427462 File Offset: 0x00425662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSysBuffNotify()
		{
		}

		// Token: 0x0601CAA6 RID: 117414 RVA: 0x00427475 File Offset: 0x00425675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSysBuffNotify(UpdateSysBuffNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.buffInfos_ = other.buffInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CAA7 RID: 117415 RVA: 0x004274AB File Offset: 0x004256AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSysBuffNotify Clone()
		{
			return new UpdateSysBuffNotify(this);
		}

		// Token: 0x170060F6 RID: 24822
		// (get) Token: 0x0601CAA8 RID: 117416 RVA: 0x004274B3 File Offset: 0x004256B3
		// (set) Token: 0x0601CAA9 RID: 117417 RVA: 0x004274BB File Offset: 0x004256BB
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

		// Token: 0x170060F7 RID: 24823
		// (get) Token: 0x0601CAAA RID: 117418 RVA: 0x004274C4 File Offset: 0x004256C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SysBuffInformation> BuffInfos
		{
			get
			{
				return this.buffInfos_;
			}
		}

		// Token: 0x0601CAAB RID: 117419 RVA: 0x004274CC File Offset: 0x004256CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSysBuffNotify);
		}

		// Token: 0x0601CAAC RID: 117420 RVA: 0x004274DC File Offset: 0x004256DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSysBuffNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.buffInfos_.Equals(other.buffInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CAAD RID: 117421 RVA: 0x0042752C File Offset: 0x0042572C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.buffInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CAAE RID: 117422 RVA: 0x00427579 File Offset: 0x00425779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CAAF RID: 117423 RVA: 0x00427586 File Offset: 0x00425786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CAB0 RID: 117424 RVA: 0x00427590 File Offset: 0x00425790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			this.buffInfos_.WriteTo(ref output, UpdateSysBuffNotify._repeated_buffInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CAB1 RID: 117425 RVA: 0x004275E0 File Offset: 0x004257E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.buffInfos_.CalculateSize(UpdateSysBuffNotify._repeated_buffInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CAB2 RID: 117426 RVA: 0x00427634 File Offset: 0x00425834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSysBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.buffInfos_.Add(other.buffInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CAB3 RID: 117427 RVA: 0x00427681 File Offset: 0x00425881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CAB4 RID: 117428 RVA: 0x0042768C File Offset: 0x0042588C
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
				if (num != 48U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.buffInfos_.AddEntriesFrom(ref input, UpdateSysBuffNotify._repeated_buffInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A51D RID: 42269
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A51E RID: 42270
		public const int EntityIdFieldNumber = 6;

		// Token: 0x0400A51F RID: 42271
		private long entityId_;

		// Token: 0x0400A520 RID: 42272
		public const int BuffInfosFieldNumber = 8;

		// Token: 0x0400A521 RID: 42273
		private static readonly FieldCodec<SysBuffInformation> _repeated_buffInfos_codec = FieldCodec.ForMessage<SysBuffInformation>(66U, SysBuffInformation.Parser);

		// Token: 0x0400A522 RID: 42274
		private readonly RepeatedField<SysBuffInformation> buffInfos_ = new RepeatedField<SysBuffInformation>();
	}
}
