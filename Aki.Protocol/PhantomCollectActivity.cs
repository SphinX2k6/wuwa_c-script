using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB3 RID: 3251
	public sealed class PhantomCollectActivity : IMessage<PhantomCollectActivity>, IMessage, IEquatable<PhantomCollectActivity>, IDeepCloneable<PhantomCollectActivity>, IBufferMessage
	{
		// Token: 0x06011A0D RID: 72205 RVA: 0x00295305 File Offset: 0x00293505
		[NullableContext(1)]
		public static PhantomCollectActivity Create()
		{
			return new PhantomCollectActivity();
		}

		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x06011A0E RID: 72206 RVA: 0x0029530C File Offset: 0x0029350C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x06011A0F RID: 72207 RVA: 0x0029530F File Offset: 0x0029350F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectActivity.Descriptor;
			}
		}

		// Token: 0x06011A10 RID: 72208 RVA: 0x00295316 File Offset: 0x00293516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectActivity()
		{
		}

		// Token: 0x06011A11 RID: 72209 RVA: 0x00295329 File Offset: 0x00293529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectActivity(PhantomCollectActivity other) : this()
		{
			this.phantomCollectRewards_ = other.phantomCollectRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A12 RID: 72210 RVA: 0x00295353 File Offset: 0x00293553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectActivity Clone()
		{
			return new PhantomCollectActivity(this);
		}

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x06011A13 RID: 72211 RVA: 0x0029535B File Offset: 0x0029355B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomCollectReward> PhantomCollectRewards
		{
			get
			{
				return this.phantomCollectRewards_;
			}
		}

		// Token: 0x06011A14 RID: 72212 RVA: 0x00295363 File Offset: 0x00293563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectActivity);
		}

		// Token: 0x06011A15 RID: 72213 RVA: 0x00295371 File Offset: 0x00293571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectActivity other)
		{
			return other != null && (other == this || (this.phantomCollectRewards_.Equals(other.phantomCollectRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A16 RID: 72214 RVA: 0x002953A4 File Offset: 0x002935A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomCollectRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011A17 RID: 72215 RVA: 0x002953D8 File Offset: 0x002935D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A18 RID: 72216 RVA: 0x002953E5 File Offset: 0x002935E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A19 RID: 72217 RVA: 0x002953EE File Offset: 0x002935EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomCollectRewards_.WriteTo(ref output, PhantomCollectActivity._repeated_phantomCollectRewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A1A RID: 72218 RVA: 0x00295418 File Offset: 0x00293618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomCollectRewards_.CalculateSize(PhantomCollectActivity._repeated_phantomCollectRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011A1B RID: 72219 RVA: 0x00295451 File Offset: 0x00293651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomCollectActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomCollectRewards_.Add(other.phantomCollectRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011A1C RID: 72220 RVA: 0x0029547F File Offset: 0x0029367F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A1D RID: 72221 RVA: 0x00295488 File Offset: 0x00293688
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
					this.phantomCollectRewards_.AddEntriesFrom(ref input, PhantomCollectActivity._repeated_phantomCollectRewards_codec);
				}
			}
		}

		// Token: 0x04006F5E RID: 28510
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F5F RID: 28511
		public const int PhantomCollectRewardsFieldNumber = 1;

		// Token: 0x04006F60 RID: 28512
		private static readonly FieldCodec<PhantomCollectReward> _repeated_phantomCollectRewards_codec = FieldCodec.ForMessage<PhantomCollectReward>(10U, PhantomCollectReward.Parser);

		// Token: 0x04006F61 RID: 28513
		private readonly RepeatedField<PhantomCollectReward> phantomCollectRewards_ = new RepeatedField<PhantomCollectReward>();
	}
}
