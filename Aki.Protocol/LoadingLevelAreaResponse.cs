using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000940 RID: 2368
	[NetMessage(EMessageId.LoadingLevelAreaResponse)]
	public sealed class LoadingLevelAreaResponse : IMessage<LoadingLevelAreaResponse>, IMessage, IEquatable<LoadingLevelAreaResponse>, IDeepCloneable<LoadingLevelAreaResponse>, IBufferMessage
	{
		// Token: 0x0600D09C RID: 53404 RVA: 0x001EB0A6 File Offset: 0x001E92A6
		[NullableContext(1)]
		public static LoadingLevelAreaResponse Create()
		{
			return new LoadingLevelAreaResponse();
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x0600D09D RID: 53405 RVA: 0x001EB0AD File Offset: 0x001E92AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x0600D09E RID: 53406 RVA: 0x001EB0B0 File Offset: 0x001E92B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadingLevelAreaResponse.Descriptor;
			}
		}

		// Token: 0x0600D09F RID: 53407 RVA: 0x001EB0B7 File Offset: 0x001E92B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaResponse()
		{
		}

		// Token: 0x0600D0A0 RID: 53408 RVA: 0x001EB0CA File Offset: 0x001E92CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaResponse(LoadingLevelAreaResponse other) : this()
		{
			this.limitConfigs_ = other.limitConfigs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0A1 RID: 53409 RVA: 0x001EB0F4 File Offset: 0x001E92F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaResponse Clone()
		{
			return new LoadingLevelAreaResponse(this);
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x0600D0A2 RID: 53410 RVA: 0x001EB0FC File Offset: 0x001E92FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LoadingAreaConfig> LimitConfigs
		{
			get
			{
				return this.limitConfigs_;
			}
		}

		// Token: 0x0600D0A3 RID: 53411 RVA: 0x001EB104 File Offset: 0x001E9304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadingLevelAreaResponse);
		}

		// Token: 0x0600D0A4 RID: 53412 RVA: 0x001EB112 File Offset: 0x001E9312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadingLevelAreaResponse other)
		{
			return other != null && (other == this || (this.limitConfigs_.Equals(other.limitConfigs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0A5 RID: 53413 RVA: 0x001EB148 File Offset: 0x001E9348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.limitConfigs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D0A6 RID: 53414 RVA: 0x001EB17C File Offset: 0x001E937C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D0A7 RID: 53415 RVA: 0x001EB189 File Offset: 0x001E9389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0A8 RID: 53416 RVA: 0x001EB192 File Offset: 0x001E9392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.limitConfigs_.WriteTo(ref output, LoadingLevelAreaResponse._repeated_limitConfigs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0A9 RID: 53417 RVA: 0x001EB1BC File Offset: 0x001E93BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.limitConfigs_.CalculateSize(LoadingLevelAreaResponse._repeated_limitConfigs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D0AA RID: 53418 RVA: 0x001EB1F5 File Offset: 0x001E93F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadingLevelAreaResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.limitConfigs_.Add(other.limitConfigs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D0AB RID: 53419 RVA: 0x001EB223 File Offset: 0x001E9423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0AC RID: 53420 RVA: 0x001EB22C File Offset: 0x001E942C
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.limitConfigs_.AddEntriesFrom(ref input, LoadingLevelAreaResponse._repeated_limitConfigs_codec);
				}
			}
		}

		// Token: 0x040057D3 RID: 22483
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057D4 RID: 22484
		public const int LimitConfigsFieldNumber = 11;

		// Token: 0x040057D5 RID: 22485
		private static readonly FieldCodec<LoadingAreaConfig> _repeated_limitConfigs_codec = FieldCodec.ForMessage<LoadingAreaConfig>(90U, LoadingAreaConfig.Parser);

		// Token: 0x040057D6 RID: 22486
		private readonly RepeatedField<LoadingAreaConfig> limitConfigs_ = new RepeatedField<LoadingAreaConfig>();
	}
}
