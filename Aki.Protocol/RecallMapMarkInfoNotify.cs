using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA2 RID: 3746
	[NetMessage(EMessageId.RecallMapMarkInfoNotify)]
	public sealed class RecallMapMarkInfoNotify : IMessage<RecallMapMarkInfoNotify>, IMessage, IEquatable<RecallMapMarkInfoNotify>, IDeepCloneable<RecallMapMarkInfoNotify>, IBufferMessage
	{
		// Token: 0x06014218 RID: 82456 RVA: 0x002EE775 File Offset: 0x002EC975
		[NullableContext(1)]
		public static RecallMapMarkInfoNotify Create()
		{
			return new RecallMapMarkInfoNotify();
		}

		// Token: 0x170042FB RID: 17147
		// (get) Token: 0x06014219 RID: 82457 RVA: 0x002EE77C File Offset: 0x002EC97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042FC RID: 17148
		// (get) Token: 0x0601421A RID: 82458 RVA: 0x002EE77F File Offset: 0x002EC97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallMapMarkInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601421B RID: 82459 RVA: 0x002EE786 File Offset: 0x002EC986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkInfoNotify()
		{
		}

		// Token: 0x0601421C RID: 82460 RVA: 0x002EE799 File Offset: 0x002EC999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkInfoNotify(RecallMapMarkInfoNotify other) : this()
		{
			this.mapMarkShowInfos_ = other.mapMarkShowInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601421D RID: 82461 RVA: 0x002EE7C3 File Offset: 0x002EC9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkInfoNotify Clone()
		{
			return new RecallMapMarkInfoNotify(this);
		}

		// Token: 0x170042FD RID: 17149
		// (get) Token: 0x0601421E RID: 82462 RVA: 0x002EE7CB File Offset: 0x002EC9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MapMarkShowInfo> MapMarkShowInfos
		{
			get
			{
				return this.mapMarkShowInfos_;
			}
		}

		// Token: 0x0601421F RID: 82463 RVA: 0x002EE7D3 File Offset: 0x002EC9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallMapMarkInfoNotify);
		}

		// Token: 0x06014220 RID: 82464 RVA: 0x002EE7E1 File Offset: 0x002EC9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallMapMarkInfoNotify other)
		{
			return other != null && (other == this || (this.mapMarkShowInfos_.Equals(other.mapMarkShowInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014221 RID: 82465 RVA: 0x002EE814 File Offset: 0x002ECA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mapMarkShowInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014222 RID: 82466 RVA: 0x002EE848 File Offset: 0x002ECA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014223 RID: 82467 RVA: 0x002EE855 File Offset: 0x002ECA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014224 RID: 82468 RVA: 0x002EE85E File Offset: 0x002ECA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mapMarkShowInfos_.WriteTo(ref output, RecallMapMarkInfoNotify._repeated_mapMarkShowInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014225 RID: 82469 RVA: 0x002EE888 File Offset: 0x002ECA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mapMarkShowInfos_.CalculateSize(RecallMapMarkInfoNotify._repeated_mapMarkShowInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014226 RID: 82470 RVA: 0x002EE8C1 File Offset: 0x002ECAC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallMapMarkInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.mapMarkShowInfos_.Add(other.mapMarkShowInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014227 RID: 82471 RVA: 0x002EE8EF File Offset: 0x002ECAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014228 RID: 82472 RVA: 0x002EE8F8 File Offset: 0x002ECAF8
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mapMarkShowInfos_.AddEntriesFrom(ref input, RecallMapMarkInfoNotify._repeated_mapMarkShowInfos_codec);
				}
			}
		}

		// Token: 0x04007B14 RID: 31508
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B15 RID: 31509
		public const int MapMarkShowInfosFieldNumber = 9;

		// Token: 0x04007B16 RID: 31510
		private static readonly FieldCodec<MapMarkShowInfo> _repeated_mapMarkShowInfos_codec = FieldCodec.ForMessage<MapMarkShowInfo>(74U, MapMarkShowInfo.Parser);

		// Token: 0x04007B17 RID: 31511
		private readonly RepeatedField<MapMarkShowInfo> mapMarkShowInfos_ = new RepeatedField<MapMarkShowInfo>();
	}
}
