using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E92 RID: 3730
	public sealed class RbLaserEmitterPbType : IMessage<RbLaserEmitterPbType>, IMessage, IEquatable<RbLaserEmitterPbType>, IDeepCloneable<RbLaserEmitterPbType>, IBufferMessage
	{
		// Token: 0x06014084 RID: 82052 RVA: 0x002EAE74 File Offset: 0x002E9074
		[NullableContext(1)]
		public static RbLaserEmitterPbType Create()
		{
			return new RbLaserEmitterPbType();
		}

		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x06014085 RID: 82053 RVA: 0x002EAE7B File Offset: 0x002E907B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042A7 RID: 17063
		// (get) Token: 0x06014086 RID: 82054 RVA: 0x002EAE7E File Offset: 0x002E907E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbLaserEmitterPbType.Descriptor;
			}
		}

		// Token: 0x06014087 RID: 82055 RVA: 0x002EAE85 File Offset: 0x002E9085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbLaserEmitterPbType()
		{
		}

		// Token: 0x06014088 RID: 82056 RVA: 0x002EAE98 File Offset: 0x002E9098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbLaserEmitterPbType(RbLaserEmitterPbType other) : this()
		{
			this.laserPoints_ = other.laserPoints_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014089 RID: 82057 RVA: 0x002EAEC2 File Offset: 0x002E90C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbLaserEmitterPbType Clone()
		{
			return new RbLaserEmitterPbType(this);
		}

		// Token: 0x170042A8 RID: 17064
		// (get) Token: 0x0601408A RID: 82058 RVA: 0x002EAECA File Offset: 0x002E90CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> LaserPoints
		{
			get
			{
				return this.laserPoints_;
			}
		}

		// Token: 0x0601408B RID: 82059 RVA: 0x002EAED2 File Offset: 0x002E90D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbLaserEmitterPbType);
		}

		// Token: 0x0601408C RID: 82060 RVA: 0x002EAEE0 File Offset: 0x002E90E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbLaserEmitterPbType other)
		{
			return other != null && (other == this || (this.laserPoints_.Equals(other.laserPoints_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601408D RID: 82061 RVA: 0x002EAF14 File Offset: 0x002E9114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.laserPoints_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601408E RID: 82062 RVA: 0x002EAF48 File Offset: 0x002E9148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601408F RID: 82063 RVA: 0x002EAF55 File Offset: 0x002E9155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014090 RID: 82064 RVA: 0x002EAF5E File Offset: 0x002E915E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.laserPoints_.WriteTo(ref output, RbLaserEmitterPbType._repeated_laserPoints_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014091 RID: 82065 RVA: 0x002EAF88 File Offset: 0x002E9188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.laserPoints_.CalculateSize(RbLaserEmitterPbType._repeated_laserPoints_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014092 RID: 82066 RVA: 0x002EAFC1 File Offset: 0x002E91C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbLaserEmitterPbType other)
		{
			if (other == null)
			{
				return;
			}
			this.laserPoints_.Add(other.laserPoints_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014093 RID: 82067 RVA: 0x002EAFEF File Offset: 0x002E91EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014094 RID: 82068 RVA: 0x002EAFF8 File Offset: 0x002E91F8
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
					this.laserPoints_.AddEntriesFrom(ref input, RbLaserEmitterPbType._repeated_laserPoints_codec);
				}
			}
		}

		// Token: 0x04007A49 RID: 31305
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A4A RID: 31306
		public const int LaserPointsFieldNumber = 1;

		// Token: 0x04007A4B RID: 31307
		private static readonly FieldCodec<Vector> _repeated_laserPoints_codec = FieldCodec.ForMessage<Vector>(10U, Vector.Parser);

		// Token: 0x04007A4C RID: 31308
		private readonly RepeatedField<Vector> laserPoints_ = new RepeatedField<Vector>();
	}
}
