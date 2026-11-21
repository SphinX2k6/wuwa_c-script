using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E82 RID: 3714
	public sealed class RbLaserEmitterPbType : IMessage<RbLaserEmitterPbType>, IMessage, IEquatable<RbLaserEmitterPbType>, IDeepCloneable<RbLaserEmitterPbType>, IBufferMessage
	{
		// Token: 0x06013F9F RID: 81823 RVA: 0x002E97B8 File Offset: 0x002E79B8
		[NullableContext(1)]
		public static RbLaserEmitterPbType Create()
		{
			return new RbLaserEmitterPbType();
		}

		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x06013FA0 RID: 81824 RVA: 0x002E97BF File Offset: 0x002E79BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x06013FA1 RID: 81825 RVA: 0x002E97C2 File Offset: 0x002E79C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbLaserEmitterPbType.Descriptor;
			}
		}

		// Token: 0x06013FA2 RID: 81826 RVA: 0x002E97C9 File Offset: 0x002E79C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbLaserEmitterPbType()
		{
		}

		// Token: 0x06013FA3 RID: 81827 RVA: 0x002E97DC File Offset: 0x002E79DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbLaserEmitterPbType(RbLaserEmitterPbType other) : this()
		{
			this.laserPoints_ = other.laserPoints_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FA4 RID: 81828 RVA: 0x002E9806 File Offset: 0x002E7A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbLaserEmitterPbType Clone()
		{
			return new RbLaserEmitterPbType(this);
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x06013FA5 RID: 81829 RVA: 0x002E980E File Offset: 0x002E7A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> LaserPoints
		{
			get
			{
				return this.laserPoints_;
			}
		}

		// Token: 0x06013FA6 RID: 81830 RVA: 0x002E9816 File Offset: 0x002E7A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbLaserEmitterPbType);
		}

		// Token: 0x06013FA7 RID: 81831 RVA: 0x002E9824 File Offset: 0x002E7A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbLaserEmitterPbType other)
		{
			return other != null && (other == this || (this.laserPoints_.Equals(other.laserPoints_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013FA8 RID: 81832 RVA: 0x002E9858 File Offset: 0x002E7A58
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

		// Token: 0x06013FA9 RID: 81833 RVA: 0x002E988C File Offset: 0x002E7A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013FAA RID: 81834 RVA: 0x002E9899 File Offset: 0x002E7A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013FAB RID: 81835 RVA: 0x002E98A2 File Offset: 0x002E7AA2
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

		// Token: 0x06013FAC RID: 81836 RVA: 0x002E98CC File Offset: 0x002E7ACC
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

		// Token: 0x06013FAD RID: 81837 RVA: 0x002E9905 File Offset: 0x002E7B05
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

		// Token: 0x06013FAE RID: 81838 RVA: 0x002E9933 File Offset: 0x002E7B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013FAF RID: 81839 RVA: 0x002E993C File Offset: 0x002E7B3C
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

		// Token: 0x04007A73 RID: 31347
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A74 RID: 31348
		public const int LaserPointsFieldNumber = 1;

		// Token: 0x04007A75 RID: 31349
		private static readonly FieldCodec<Vector> _repeated_laserPoints_codec = FieldCodec.ForMessage<Vector>(10U, Vector.Parser);

		// Token: 0x04007A76 RID: 31350
		private readonly RepeatedField<Vector> laserPoints_ = new RepeatedField<Vector>();
	}
}
