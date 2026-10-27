using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001528 RID: 5416
	[NetMessage(EMessageId.WuWuTaskRewardRequest)]
	public sealed class WuWuTaskRewardRequest : IMessage<WuWuTaskRewardRequest>, IMessage, IEquatable<WuWuTaskRewardRequest>, IDeepCloneable<WuWuTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0601C9F5 RID: 117237 RVA: 0x00422256 File Offset: 0x00420456
		[NullableContext(1)]
		public static WuWuTaskRewardRequest Create()
		{
			return new WuWuTaskRewardRequest();
		}

		// Token: 0x17006081 RID: 24705
		// (get) Token: 0x0601C9F6 RID: 117238 RVA: 0x0042225D File Offset: 0x0042045D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006082 RID: 24706
		// (get) Token: 0x0601C9F7 RID: 117239 RVA: 0x00422260 File Offset: 0x00420460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601C9F8 RID: 117240 RVA: 0x00422267 File Offset: 0x00420467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardRequest()
		{
		}

		// Token: 0x0601C9F9 RID: 117241 RVA: 0x0042227A File Offset: 0x0042047A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardRequest(WuWuTaskRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C9FA RID: 117242 RVA: 0x004222A4 File Offset: 0x004204A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardRequest Clone()
		{
			return new WuWuTaskRewardRequest(this);
		}

		// Token: 0x17006083 RID: 24707
		// (get) Token: 0x0601C9FB RID: 117243 RVA: 0x004222AC File Offset: 0x004204AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601C9FC RID: 117244 RVA: 0x004222B4 File Offset: 0x004204B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuTaskRewardRequest);
		}

		// Token: 0x0601C9FD RID: 117245 RVA: 0x004222C2 File Offset: 0x004204C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C9FE RID: 117246 RVA: 0x004222F8 File Offset: 0x004204F8
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

		// Token: 0x0601C9FF RID: 117247 RVA: 0x0042232C File Offset: 0x0042052C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA00 RID: 117248 RVA: 0x00422339 File Offset: 0x00420539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA01 RID: 117249 RVA: 0x00422342 File Offset: 0x00420542
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

		// Token: 0x0601CA02 RID: 117250 RVA: 0x0042236C File Offset: 0x0042056C
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

		// Token: 0x0601CA03 RID: 117251 RVA: 0x004223A5 File Offset: 0x004205A5
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

		// Token: 0x0601CA04 RID: 117252 RVA: 0x004223D3 File Offset: 0x004205D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA05 RID: 117253 RVA: 0x004223DC File Offset: 0x004205DC
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, WuWuTaskRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400A3AD RID: 41901
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3AE RID: 41902
		public const int IdsFieldNumber = 15;

		// Token: 0x0400A3AF RID: 41903
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400A3B0 RID: 41904
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
