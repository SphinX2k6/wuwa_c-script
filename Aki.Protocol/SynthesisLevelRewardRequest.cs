using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001312 RID: 4882
	[NetMessage(EMessageId.SynthesisLevelRewardRequest)]
	public sealed class SynthesisLevelRewardRequest : IMessage<SynthesisLevelRewardRequest>, IMessage, IEquatable<SynthesisLevelRewardRequest>, IDeepCloneable<SynthesisLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x06019F25 RID: 106277 RVA: 0x003C518B File Offset: 0x003C338B
		[NullableContext(1)]
		public static SynthesisLevelRewardRequest Create()
		{
			return new SynthesisLevelRewardRequest();
		}

		// Token: 0x17005780 RID: 22400
		// (get) Token: 0x06019F26 RID: 106278 RVA: 0x003C5192 File Offset: 0x003C3392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005781 RID: 22401
		// (get) Token: 0x06019F27 RID: 106279 RVA: 0x003C5195 File Offset: 0x003C3395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019F28 RID: 106280 RVA: 0x003C519C File Offset: 0x003C339C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardRequest()
		{
		}

		// Token: 0x06019F29 RID: 106281 RVA: 0x003C51A4 File Offset: 0x003C33A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardRequest(SynthesisLevelRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F2A RID: 106282 RVA: 0x003C51BD File Offset: 0x003C33BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardRequest Clone()
		{
			return new SynthesisLevelRewardRequest(this);
		}

		// Token: 0x06019F2B RID: 106283 RVA: 0x003C51C5 File Offset: 0x003C33C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisLevelRewardRequest);
		}

		// Token: 0x06019F2C RID: 106284 RVA: 0x003C51D3 File Offset: 0x003C33D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisLevelRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019F2D RID: 106285 RVA: 0x003C51F4 File Offset: 0x003C33F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019F2E RID: 106286 RVA: 0x003C521A File Offset: 0x003C341A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F2F RID: 106287 RVA: 0x003C5227 File Offset: 0x003C3427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F30 RID: 106288 RVA: 0x003C5230 File Offset: 0x003C3430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F31 RID: 106289 RVA: 0x003C5248 File Offset: 0x003C3448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019F32 RID: 106290 RVA: 0x003C526E File Offset: 0x003C346E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019F33 RID: 106291 RVA: 0x003C528B File Offset: 0x003C348B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F34 RID: 106292 RVA: 0x003C5294 File Offset: 0x003C3494
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040097A4 RID: 38820
		private UnknownFieldSet _unknownFields;
	}
}
