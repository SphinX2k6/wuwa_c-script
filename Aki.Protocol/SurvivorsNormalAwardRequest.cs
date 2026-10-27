using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D3 RID: 4819
	[NetMessage(EMessageId.SurvivorsNormalAwardRequest)]
	public sealed class SurvivorsNormalAwardRequest : IMessage<SurvivorsNormalAwardRequest>, IMessage, IEquatable<SurvivorsNormalAwardRequest>, IDeepCloneable<SurvivorsNormalAwardRequest>, IBufferMessage
	{
		// Token: 0x06019A2F RID: 105007 RVA: 0x003B9FA4 File Offset: 0x003B81A4
		[NullableContext(1)]
		public static SurvivorsNormalAwardRequest Create()
		{
			return new SurvivorsNormalAwardRequest();
		}

		// Token: 0x1700567B RID: 22139
		// (get) Token: 0x06019A30 RID: 105008 RVA: 0x003B9FAB File Offset: 0x003B81AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700567C RID: 22140
		// (get) Token: 0x06019A31 RID: 105009 RVA: 0x003B9FAE File Offset: 0x003B81AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsNormalAwardRequest.Descriptor;
			}
		}

		// Token: 0x06019A32 RID: 105010 RVA: 0x003B9FB5 File Offset: 0x003B81B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardRequest()
		{
		}

		// Token: 0x06019A33 RID: 105011 RVA: 0x003B9FC8 File Offset: 0x003B81C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardRequest(SurvivorsNormalAwardRequest other) : this()
		{
			this.configs_ = other.configs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A34 RID: 105012 RVA: 0x003B9FF2 File Offset: 0x003B81F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsNormalAwardRequest Clone()
		{
			return new SurvivorsNormalAwardRequest(this);
		}

		// Token: 0x1700567D RID: 22141
		// (get) Token: 0x06019A35 RID: 105013 RVA: 0x003B9FFA File Offset: 0x003B81FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Configs
		{
			get
			{
				return this.configs_;
			}
		}

		// Token: 0x06019A36 RID: 105014 RVA: 0x003BA002 File Offset: 0x003B8202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsNormalAwardRequest);
		}

		// Token: 0x06019A37 RID: 105015 RVA: 0x003BA010 File Offset: 0x003B8210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsNormalAwardRequest other)
		{
			return other != null && (other == this || (this.configs_.Equals(other.configs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A38 RID: 105016 RVA: 0x003BA044 File Offset: 0x003B8244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.configs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A39 RID: 105017 RVA: 0x003BA078 File Offset: 0x003B8278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A3A RID: 105018 RVA: 0x003BA085 File Offset: 0x003B8285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A3B RID: 105019 RVA: 0x003BA08E File Offset: 0x003B828E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.configs_.WriteTo(ref output, SurvivorsNormalAwardRequest._repeated_configs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A3C RID: 105020 RVA: 0x003BA0B8 File Offset: 0x003B82B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.configs_.CalculateSize(SurvivorsNormalAwardRequest._repeated_configs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A3D RID: 105021 RVA: 0x003BA0F1 File Offset: 0x003B82F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsNormalAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.configs_.Add(other.configs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A3E RID: 105022 RVA: 0x003BA11F File Offset: 0x003B831F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A3F RID: 105023 RVA: 0x003BA128 File Offset: 0x003B8328
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.configs_.AddEntriesFrom(ref input, SurvivorsNormalAwardRequest._repeated_configs_codec);
				}
			}
		}

		// Token: 0x04009651 RID: 38481
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009652 RID: 38482
		public const int ConfigsFieldNumber = 9;

		// Token: 0x04009653 RID: 38483
		private static readonly FieldCodec<int> _repeated_configs_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04009654 RID: 38484
		private readonly RepeatedField<int> configs_ = new RepeatedField<int>();
	}
}
