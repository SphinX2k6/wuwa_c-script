using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B80 RID: 2944
	[NetMessage(EMessageId.OccupyRewardRequest)]
	public sealed class OccupyRewardRequest : IMessage<OccupyRewardRequest>, IMessage, IEquatable<OccupyRewardRequest>, IDeepCloneable<OccupyRewardRequest>, IBufferMessage
	{
		// Token: 0x0600FF2A RID: 65322 RVA: 0x00253676 File Offset: 0x00251876
		[NullableContext(1)]
		public static OccupyRewardRequest Create()
		{
			return new OccupyRewardRequest();
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600FF2B RID: 65323 RVA: 0x0025367D File Offset: 0x0025187D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600FF2C RID: 65324 RVA: 0x00253680 File Offset: 0x00251880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OccupyRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600FF2D RID: 65325 RVA: 0x00253687 File Offset: 0x00251887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardRequest()
		{
		}

		// Token: 0x0600FF2E RID: 65326 RVA: 0x0025369A File Offset: 0x0025189A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardRequest(OccupyRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF2F RID: 65327 RVA: 0x002536C4 File Offset: 0x002518C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupyRewardRequest Clone()
		{
			return new OccupyRewardRequest(this);
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600FF30 RID: 65328 RVA: 0x002536CC File Offset: 0x002518CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600FF31 RID: 65329 RVA: 0x002536D4 File Offset: 0x002518D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OccupyRewardRequest);
		}

		// Token: 0x0600FF32 RID: 65330 RVA: 0x002536E2 File Offset: 0x002518E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OccupyRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF33 RID: 65331 RVA: 0x00253718 File Offset: 0x00251918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FF34 RID: 65332 RVA: 0x0025374C File Offset: 0x0025194C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF35 RID: 65333 RVA: 0x00253759 File Offset: 0x00251959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF36 RID: 65334 RVA: 0x00253762 File Offset: 0x00251962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, OccupyRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FF37 RID: 65335 RVA: 0x0025378C File Offset: 0x0025198C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(OccupyRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FF38 RID: 65336 RVA: 0x002537C5 File Offset: 0x002519C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OccupyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FF39 RID: 65337 RVA: 0x002537F3 File Offset: 0x002519F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF3A RID: 65338 RVA: 0x002537FC File Offset: 0x002519FC
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, OccupyRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x040065A4 RID: 26020
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065A5 RID: 26021
		public const int IdsFieldNumber = 10;

		// Token: 0x040065A6 RID: 26022
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040065A7 RID: 26023
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
