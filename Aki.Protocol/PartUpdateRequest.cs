using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC9 RID: 3017
	[NetMessage(EMessageId.PartUpdateRequest)]
	public sealed class PartUpdateRequest : IMessage<PartUpdateRequest>, IMessage, IEquatable<PartUpdateRequest>, IDeepCloneable<PartUpdateRequest>, IBufferMessage
	{
		// Token: 0x06010587 RID: 66951 RVA: 0x0026268C File Offset: 0x0026088C
		[NullableContext(1)]
		public static PartUpdateRequest Create()
		{
			return new PartUpdateRequest();
		}

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x06010588 RID: 66952 RVA: 0x00262693 File Offset: 0x00260893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x06010589 RID: 66953 RVA: 0x00262696 File Offset: 0x00260896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601058A RID: 66954 RVA: 0x0026269D File Offset: 0x0026089D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateRequest()
		{
		}

		// Token: 0x0601058B RID: 66955 RVA: 0x002626B0 File Offset: 0x002608B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateRequest(PartUpdateRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.partUpdateInfos_ = other.partUpdateInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601058C RID: 66956 RVA: 0x002626E6 File Offset: 0x002608E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateRequest Clone()
		{
			return new PartUpdateRequest(this);
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0601058D RID: 66957 RVA: 0x002626EE File Offset: 0x002608EE
		// (set) Token: 0x0601058E RID: 66958 RVA: 0x002626F6 File Offset: 0x002608F6
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

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0601058F RID: 66959 RVA: 0x002626FF File Offset: 0x002608FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartUpdateInfo> PartUpdateInfos
		{
			get
			{
				return this.partUpdateInfos_;
			}
		}

		// Token: 0x06010590 RID: 66960 RVA: 0x00262707 File Offset: 0x00260907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartUpdateRequest);
		}

		// Token: 0x06010591 RID: 66961 RVA: 0x00262718 File Offset: 0x00260918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartUpdateRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.partUpdateInfos_.Equals(other.partUpdateInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010592 RID: 66962 RVA: 0x00262768 File Offset: 0x00260968
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

		// Token: 0x06010593 RID: 66963 RVA: 0x002627B5 File Offset: 0x002609B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010594 RID: 66964 RVA: 0x002627C2 File Offset: 0x002609C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010595 RID: 66965 RVA: 0x002627CC File Offset: 0x002609CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			this.partUpdateInfos_.WriteTo(ref output, PartUpdateRequest._repeated_partUpdateInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010596 RID: 66966 RVA: 0x0026281C File Offset: 0x00260A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.partUpdateInfos_.CalculateSize(PartUpdateRequest._repeated_partUpdateInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010597 RID: 66967 RVA: 0x00262870 File Offset: 0x00260A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartUpdateRequest other)
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

		// Token: 0x06010598 RID: 66968 RVA: 0x002628BD File Offset: 0x00260ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010599 RID: 66969 RVA: 0x002628C8 File Offset: 0x00260AC8
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
				if (num != 64U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.partUpdateInfos_.AddEntriesFrom(ref input, PartUpdateRequest._repeated_partUpdateInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040067D5 RID: 26581
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067D6 RID: 26582
		public const int EntityIdFieldNumber = 8;

		// Token: 0x040067D7 RID: 26583
		private long entityId_;

		// Token: 0x040067D8 RID: 26584
		public const int PartUpdateInfosFieldNumber = 12;

		// Token: 0x040067D9 RID: 26585
		private static readonly FieldCodec<PartUpdateInfo> _repeated_partUpdateInfos_codec = FieldCodec.ForMessage<PartUpdateInfo>(98U, PartUpdateInfo.Parser);

		// Token: 0x040067DA RID: 26586
		private readonly RepeatedField<PartUpdateInfo> partUpdateInfos_ = new RepeatedField<PartUpdateInfo>();
	}
}
