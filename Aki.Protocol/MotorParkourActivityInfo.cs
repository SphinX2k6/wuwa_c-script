using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A92 RID: 2706
	public sealed class MotorParkourActivityInfo : IMessage<MotorParkourActivityInfo>, IMessage, IEquatable<MotorParkourActivityInfo>, IDeepCloneable<MotorParkourActivityInfo>, IBufferMessage
	{
		// Token: 0x0600EBAB RID: 60331 RVA: 0x00226904 File Offset: 0x00224B04
		[NullableContext(1)]
		public static MotorParkourActivityInfo Create()
		{
			return new MotorParkourActivityInfo();
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x0600EBAC RID: 60332 RVA: 0x0022690B File Offset: 0x00224B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x0600EBAD RID: 60333 RVA: 0x0022690E File Offset: 0x00224B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600EBAE RID: 60334 RVA: 0x00226915 File Offset: 0x00224B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourActivityInfo()
		{
		}

		// Token: 0x0600EBAF RID: 60335 RVA: 0x00226928 File Offset: 0x00224B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourActivityInfo(MotorParkourActivityInfo other) : this()
		{
			this.motorParkourLevelInfos_ = other.motorParkourLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EBB0 RID: 60336 RVA: 0x00226952 File Offset: 0x00224B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourActivityInfo Clone()
		{
			return new MotorParkourActivityInfo(this);
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x0600EBB1 RID: 60337 RVA: 0x0022695A File Offset: 0x00224B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorParkourLevelInfo> MotorParkourLevelInfos
		{
			get
			{
				return this.motorParkourLevelInfos_;
			}
		}

		// Token: 0x0600EBB2 RID: 60338 RVA: 0x00226962 File Offset: 0x00224B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourActivityInfo);
		}

		// Token: 0x0600EBB3 RID: 60339 RVA: 0x00226970 File Offset: 0x00224B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourActivityInfo other)
		{
			return other != null && (other == this || (this.motorParkourLevelInfos_.Equals(other.motorParkourLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EBB4 RID: 60340 RVA: 0x002269A4 File Offset: 0x00224BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorParkourLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EBB5 RID: 60341 RVA: 0x002269D8 File Offset: 0x00224BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EBB6 RID: 60342 RVA: 0x002269E5 File Offset: 0x00224BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EBB7 RID: 60343 RVA: 0x002269EE File Offset: 0x00224BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorParkourLevelInfos_.WriteTo(ref output, MotorParkourActivityInfo._repeated_motorParkourLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EBB8 RID: 60344 RVA: 0x00226A18 File Offset: 0x00224C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorParkourLevelInfos_.CalculateSize(MotorParkourActivityInfo._repeated_motorParkourLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EBB9 RID: 60345 RVA: 0x00226A51 File Offset: 0x00224C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorParkourActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.motorParkourLevelInfos_.Add(other.motorParkourLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EBBA RID: 60346 RVA: 0x00226A7F File Offset: 0x00224C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EBBB RID: 60347 RVA: 0x00226A88 File Offset: 0x00224C88
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
					this.motorParkourLevelInfos_.AddEntriesFrom(ref input, MotorParkourActivityInfo._repeated_motorParkourLevelInfos_codec);
				}
			}
		}

		// Token: 0x04005FA0 RID: 24480
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FA1 RID: 24481
		public const int MotorParkourLevelInfosFieldNumber = 1;

		// Token: 0x04005FA2 RID: 24482
		private static readonly FieldCodec<MotorParkourLevelInfo> _repeated_motorParkourLevelInfos_codec = FieldCodec.ForMessage<MotorParkourLevelInfo>(10U, MotorParkourLevelInfo.Parser);

		// Token: 0x04005FA3 RID: 24483
		private readonly RepeatedField<MotorParkourLevelInfo> motorParkourLevelInfos_ = new RepeatedField<MotorParkourLevelInfo>();
	}
}
