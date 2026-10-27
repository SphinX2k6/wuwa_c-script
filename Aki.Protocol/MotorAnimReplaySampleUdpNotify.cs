using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1E RID: 2590
	[NetMessage(EMessageId.MotorAnimReplaySampleUdpNotify)]
	public sealed class MotorAnimReplaySampleUdpNotify : IMessage<MotorAnimReplaySampleUdpNotify>, IMessage, IEquatable<MotorAnimReplaySampleUdpNotify>, IDeepCloneable<MotorAnimReplaySampleUdpNotify>, IBufferMessage
	{
		// Token: 0x0600E287 RID: 57991 RVA: 0x00212E2C File Offset: 0x0021102C
		[NullableContext(1)]
		public static MotorAnimReplaySampleUdpNotify Create()
		{
			return new MotorAnimReplaySampleUdpNotify();
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x0600E288 RID: 57992 RVA: 0x00212E33 File Offset: 0x00211033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x0600E289 RID: 57993 RVA: 0x00212E36 File Offset: 0x00211036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorAnimReplaySampleUdpNotify.Descriptor;
			}
		}

		// Token: 0x0600E28A RID: 57994 RVA: 0x00212E3D File Offset: 0x0021103D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpNotify()
		{
		}

		// Token: 0x0600E28B RID: 57995 RVA: 0x00212E50 File Offset: 0x00211050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpNotify(MotorAnimReplaySampleUdpNotify other) : this()
		{
			this.motorAnimEntities_ = other.motorAnimEntities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E28C RID: 57996 RVA: 0x00212E7A File Offset: 0x0021107A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimReplaySampleUdpNotify Clone()
		{
			return new MotorAnimReplaySampleUdpNotify(this);
		}

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x0600E28D RID: 57997 RVA: 0x00212E82 File Offset: 0x00211082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorAnimEntity> MotorAnimEntities
		{
			get
			{
				return this.motorAnimEntities_;
			}
		}

		// Token: 0x0600E28E RID: 57998 RVA: 0x00212E8A File Offset: 0x0021108A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorAnimReplaySampleUdpNotify);
		}

		// Token: 0x0600E28F RID: 57999 RVA: 0x00212E98 File Offset: 0x00211098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorAnimReplaySampleUdpNotify other)
		{
			return other != null && (other == this || (this.motorAnimEntities_.Equals(other.motorAnimEntities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E290 RID: 58000 RVA: 0x00212ECC File Offset: 0x002110CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorAnimEntities_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E291 RID: 58001 RVA: 0x00212F00 File Offset: 0x00211100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E292 RID: 58002 RVA: 0x00212F0D File Offset: 0x0021110D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E293 RID: 58003 RVA: 0x00212F16 File Offset: 0x00211116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorAnimEntities_.WriteTo(ref output, MotorAnimReplaySampleUdpNotify._repeated_motorAnimEntities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E294 RID: 58004 RVA: 0x00212F40 File Offset: 0x00211140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorAnimEntities_.CalculateSize(MotorAnimReplaySampleUdpNotify._repeated_motorAnimEntities_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E295 RID: 58005 RVA: 0x00212F79 File Offset: 0x00211179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorAnimReplaySampleUdpNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.motorAnimEntities_.Add(other.motorAnimEntities_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E296 RID: 58006 RVA: 0x00212FA7 File Offset: 0x002111A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E297 RID: 58007 RVA: 0x00212FB0 File Offset: 0x002111B0
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.motorAnimEntities_.AddEntriesFrom(ref input, MotorAnimReplaySampleUdpNotify._repeated_motorAnimEntities_codec);
				}
			}
		}

		// Token: 0x04005D02 RID: 23810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D03 RID: 23811
		public const int MotorAnimEntitiesFieldNumber = 2;

		// Token: 0x04005D04 RID: 23812
		private static readonly FieldCodec<MotorAnimEntity> _repeated_motorAnimEntities_codec = FieldCodec.ForMessage<MotorAnimEntity>(18U, MotorAnimEntity.Parser);

		// Token: 0x04005D05 RID: 23813
		private readonly RepeatedField<MotorAnimEntity> motorAnimEntities_ = new RepeatedField<MotorAnimEntity>();
	}
}
