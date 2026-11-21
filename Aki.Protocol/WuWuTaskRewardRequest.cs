using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200159E RID: 5534
	[NetMessage(EMessageId.WuWuTaskRewardRequest)]
	public sealed class WuWuTaskRewardRequest : IMessage<WuWuTaskRewardRequest>, IMessage, IEquatable<WuWuTaskRewardRequest>, IDeepCloneable<WuWuTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0601D4BC RID: 119996 RVA: 0x0043DD12 File Offset: 0x0043BF12
		[NullableContext(1)]
		public static WuWuTaskRewardRequest Create()
		{
			return new WuWuTaskRewardRequest();
		}

		// Token: 0x17006322 RID: 25378
		// (get) Token: 0x0601D4BD RID: 119997 RVA: 0x0043DD19 File Offset: 0x0043BF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006323 RID: 25379
		// (get) Token: 0x0601D4BE RID: 119998 RVA: 0x0043DD1C File Offset: 0x0043BF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601D4BF RID: 119999 RVA: 0x0043DD23 File Offset: 0x0043BF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardRequest()
		{
		}

		// Token: 0x0601D4C0 RID: 120000 RVA: 0x0043DD36 File Offset: 0x0043BF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardRequest(WuWuTaskRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D4C1 RID: 120001 RVA: 0x0043DD60 File Offset: 0x0043BF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardRequest Clone()
		{
			return new WuWuTaskRewardRequest(this);
		}

		// Token: 0x17006324 RID: 25380
		// (get) Token: 0x0601D4C2 RID: 120002 RVA: 0x0043DD68 File Offset: 0x0043BF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601D4C3 RID: 120003 RVA: 0x0043DD70 File Offset: 0x0043BF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuTaskRewardRequest);
		}

		// Token: 0x0601D4C4 RID: 120004 RVA: 0x0043DD7E File Offset: 0x0043BF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D4C5 RID: 120005 RVA: 0x0043DDB4 File Offset: 0x0043BFB4
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

		// Token: 0x0601D4C6 RID: 120006 RVA: 0x0043DDE8 File Offset: 0x0043BFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D4C7 RID: 120007 RVA: 0x0043DDF5 File Offset: 0x0043BFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D4C8 RID: 120008 RVA: 0x0043DDFE File Offset: 0x0043BFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, WuWuTaskRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D4C9 RID: 120009 RVA: 0x0043DE28 File Offset: 0x0043C028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(WuWuTaskRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D4CA RID: 120010 RVA: 0x0043DE61 File Offset: 0x0043C061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D4CB RID: 120011 RVA: 0x0043DE8F File Offset: 0x0043C08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D4CC RID: 120012 RVA: 0x0043DE98 File Offset: 0x0043C098
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, WuWuTaskRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400A806 RID: 43014
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A807 RID: 43015
		public const int IdsFieldNumber = 14;

		// Token: 0x0400A808 RID: 43016
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400A809 RID: 43017
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
