using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095F RID: 2399
	[NetMessage(EMessageId.LordGymGroupInfoUpdateNotify)]
	public sealed class LordGymGroupInfoUpdateNotify : IMessage<LordGymGroupInfoUpdateNotify>, IMessage, IEquatable<LordGymGroupInfoUpdateNotify>, IDeepCloneable<LordGymGroupInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D361 RID: 54113 RVA: 0x001F2463 File Offset: 0x001F0663
		[NullableContext(1)]
		public static LordGymGroupInfoUpdateNotify Create()
		{
			return new LordGymGroupInfoUpdateNotify();
		}

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x0600D362 RID: 54114 RVA: 0x001F246A File Offset: 0x001F066A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x0600D363 RID: 54115 RVA: 0x001F246D File Offset: 0x001F066D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymGroupInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D364 RID: 54116 RVA: 0x001F2474 File Offset: 0x001F0674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfoUpdateNotify()
		{
		}

		// Token: 0x0600D365 RID: 54117 RVA: 0x001F2487 File Offset: 0x001F0687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfoUpdateNotify(LordGymGroupInfoUpdateNotify other) : this()
		{
			this.lordGymGroupInfos_ = other.lordGymGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D366 RID: 54118 RVA: 0x001F24B1 File Offset: 0x001F06B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymGroupInfoUpdateNotify Clone()
		{
			return new LordGymGroupInfoUpdateNotify(this);
		}

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x0600D367 RID: 54119 RVA: 0x001F24B9 File Offset: 0x001F06B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LordGymGroupInfo> LordGymGroupInfos
		{
			get
			{
				return this.lordGymGroupInfos_;
			}
		}

		// Token: 0x0600D368 RID: 54120 RVA: 0x001F24C1 File Offset: 0x001F06C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymGroupInfoUpdateNotify);
		}

		// Token: 0x0600D369 RID: 54121 RVA: 0x001F24CF File Offset: 0x001F06CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymGroupInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.lordGymGroupInfos_.Equals(other.lordGymGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D36A RID: 54122 RVA: 0x001F2504 File Offset: 0x001F0704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lordGymGroupInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D36B RID: 54123 RVA: 0x001F2538 File Offset: 0x001F0738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D36C RID: 54124 RVA: 0x001F2545 File Offset: 0x001F0745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D36D RID: 54125 RVA: 0x001F254E File Offset: 0x001F074E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lordGymGroupInfos_.WriteTo(ref output, LordGymGroupInfoUpdateNotify._repeated_lordGymGroupInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D36E RID: 54126 RVA: 0x001F2578 File Offset: 0x001F0778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lordGymGroupInfos_.CalculateSize(LordGymGroupInfoUpdateNotify._repeated_lordGymGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D36F RID: 54127 RVA: 0x001F25B1 File Offset: 0x001F07B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymGroupInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.lordGymGroupInfos_.Add(other.lordGymGroupInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D370 RID: 54128 RVA: 0x001F25DF File Offset: 0x001F07DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D371 RID: 54129 RVA: 0x001F25E8 File Offset: 0x001F07E8
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.lordGymGroupInfos_.AddEntriesFrom(ref input, LordGymGroupInfoUpdateNotify._repeated_lordGymGroupInfos_codec);
				}
			}
		}

		// Token: 0x040058D3 RID: 22739
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058D4 RID: 22740
		public const int LordGymGroupInfosFieldNumber = 4;

		// Token: 0x040058D5 RID: 22741
		private static readonly FieldCodec<LordGymGroupInfo> _repeated_lordGymGroupInfos_codec = FieldCodec.ForMessage<LordGymGroupInfo>(34U, LordGymGroupInfo.Parser);

		// Token: 0x040058D6 RID: 22742
		private readonly RepeatedField<LordGymGroupInfo> lordGymGroupInfos_ = new RepeatedField<LordGymGroupInfo>();
	}
}
