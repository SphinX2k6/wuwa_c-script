using System;

namespace System.Reflection.Emit
{
	// Token: 0x020007CB RID: 1995
	public class OpCodes
	{
		// Token: 0x06008030 RID: 32816 RVA: 0x0012E1E4 File Offset: 0x0012C3E4
		public static bool TakesSingleByteArgument(OpCode inst)
		{
			OperandType operandType = inst.OperandType;
			return operandType - OperandType.ShortInlineBrTarget <= 1 || operandType == OperandType.ShortInlineVar;
		}

		// Token: 0x04001998 RID: 6552
		public static readonly OpCode Nop = new OpCode(OpCodeValues.Nop, 6556325);

		// Token: 0x04001999 RID: 6553
		public static readonly OpCode Break = new OpCode(OpCodeValues.Break, 6556197);

		// Token: 0x0400199A RID: 6554
		public static readonly OpCode Ldarg_0 = new OpCode(OpCodeValues.Ldarg_0, 275120805);

		// Token: 0x0400199B RID: 6555
		public static readonly OpCode Ldarg_1 = new OpCode(OpCodeValues.Ldarg_1, 275120805);

		// Token: 0x0400199C RID: 6556
		public static readonly OpCode Ldarg_2 = new OpCode(OpCodeValues.Ldarg_2, 275120805);

		// Token: 0x0400199D RID: 6557
		public static readonly OpCode Ldarg_3 = new OpCode(OpCodeValues.Ldarg_3, 275120805);

		// Token: 0x0400199E RID: 6558
		public static readonly OpCode Ldloc_0 = new OpCode(OpCodeValues.Ldloc_0, 275120805);

		// Token: 0x0400199F RID: 6559
		public static readonly OpCode Ldloc_1 = new OpCode(OpCodeValues.Ldloc_1, 275120805);

		// Token: 0x040019A0 RID: 6560
		public static readonly OpCode Ldloc_2 = new OpCode(OpCodeValues.Ldloc_2, 275120805);

		// Token: 0x040019A1 RID: 6561
		public static readonly OpCode Ldloc_3 = new OpCode(OpCodeValues.Ldloc_3, 275120805);

		// Token: 0x040019A2 RID: 6562
		public static readonly OpCode Stloc_0 = new OpCode(OpCodeValues.Stloc_0, -261877083);

		// Token: 0x040019A3 RID: 6563
		public static readonly OpCode Stloc_1 = new OpCode(OpCodeValues.Stloc_1, -261877083);

		// Token: 0x040019A4 RID: 6564
		public static readonly OpCode Stloc_2 = new OpCode(OpCodeValues.Stloc_2, -261877083);

		// Token: 0x040019A5 RID: 6565
		public static readonly OpCode Stloc_3 = new OpCode(OpCodeValues.Stloc_3, -261877083);

		// Token: 0x040019A6 RID: 6566
		public static readonly OpCode Ldarg_S = new OpCode(OpCodeValues.Ldarg_S, 275120818);

		// Token: 0x040019A7 RID: 6567
		public static readonly OpCode Ldarga_S = new OpCode(OpCodeValues.Ldarga_S, 275382962);

		// Token: 0x040019A8 RID: 6568
		public static readonly OpCode Starg_S = new OpCode(OpCodeValues.Starg_S, -261877070);

		// Token: 0x040019A9 RID: 6569
		public static readonly OpCode Ldloc_S = new OpCode(OpCodeValues.Ldloc_S, 275120818);

		// Token: 0x040019AA RID: 6570
		public static readonly OpCode Ldloca_S = new OpCode(OpCodeValues.Ldloca_S, 275382962);

		// Token: 0x040019AB RID: 6571
		public static readonly OpCode Stloc_S = new OpCode(OpCodeValues.Stloc_S, -261877070);

		// Token: 0x040019AC RID: 6572
		public static readonly OpCode Ldnull = new OpCode(OpCodeValues.Ldnull, 275909285);

		// Token: 0x040019AD RID: 6573
		public static readonly OpCode Ldc_I4_M1 = new OpCode(OpCodeValues.Ldc_I4_M1, 275382949);

		// Token: 0x040019AE RID: 6574
		public static readonly OpCode Ldc_I4_0 = new OpCode(OpCodeValues.Ldc_I4_0, 275382949);

		// Token: 0x040019AF RID: 6575
		public static readonly OpCode Ldc_I4_1 = new OpCode(OpCodeValues.Ldc_I4_1, 275382949);

		// Token: 0x040019B0 RID: 6576
		public static readonly OpCode Ldc_I4_2 = new OpCode(OpCodeValues.Ldc_I4_2, 275382949);

		// Token: 0x040019B1 RID: 6577
		public static readonly OpCode Ldc_I4_3 = new OpCode(OpCodeValues.Ldc_I4_3, 275382949);

		// Token: 0x040019B2 RID: 6578
		public static readonly OpCode Ldc_I4_4 = new OpCode(OpCodeValues.Ldc_I4_4, 275382949);

		// Token: 0x040019B3 RID: 6579
		public static readonly OpCode Ldc_I4_5 = new OpCode(OpCodeValues.Ldc_I4_5, 275382949);

		// Token: 0x040019B4 RID: 6580
		public static readonly OpCode Ldc_I4_6 = new OpCode(OpCodeValues.Ldc_I4_6, 275382949);

		// Token: 0x040019B5 RID: 6581
		public static readonly OpCode Ldc_I4_7 = new OpCode(OpCodeValues.Ldc_I4_7, 275382949);

		// Token: 0x040019B6 RID: 6582
		public static readonly OpCode Ldc_I4_8 = new OpCode(OpCodeValues.Ldc_I4_8, 275382949);

		// Token: 0x040019B7 RID: 6583
		public static readonly OpCode Ldc_I4_S = new OpCode(OpCodeValues.Ldc_I4_S, 275382960);

		// Token: 0x040019B8 RID: 6584
		public static readonly OpCode Ldc_I4 = new OpCode(OpCodeValues.Ldc_I4, 275384994);

		// Token: 0x040019B9 RID: 6585
		public static readonly OpCode Ldc_I8 = new OpCode(OpCodeValues.Ldc_I8, 275516067);

		// Token: 0x040019BA RID: 6586
		public static readonly OpCode Ldc_R4 = new OpCode(OpCodeValues.Ldc_R4, 275647153);

		// Token: 0x040019BB RID: 6587
		public static readonly OpCode Ldc_R8 = new OpCode(OpCodeValues.Ldc_R8, 275778215);

		// Token: 0x040019BC RID: 6588
		public static readonly OpCode Dup = new OpCode(OpCodeValues.Dup, 275258021);

		// Token: 0x040019BD RID: 6589
		public static readonly OpCode Pop = new OpCode(OpCodeValues.Pop, -261875035);

		// Token: 0x040019BE RID: 6590
		public static readonly OpCode Jmp = new OpCode(OpCodeValues.Jmp, 23333444);

		// Token: 0x040019BF RID: 6591
		public static readonly OpCode Call = new OpCode(OpCodeValues.Call, 7842372);

		// Token: 0x040019C0 RID: 6592
		public static readonly OpCode Calli = new OpCode(OpCodeValues.Calli, 7842377);

		// Token: 0x040019C1 RID: 6593
		public static readonly OpCode Ret = new OpCode(OpCodeValues.Ret, 23440101);

		// Token: 0x040019C2 RID: 6594
		public static readonly OpCode Br_S = new OpCode(OpCodeValues.Br_S, 23331343);

		// Token: 0x040019C3 RID: 6595
		public static readonly OpCode Brfalse_S = new OpCode(OpCodeValues.Brfalse_S, -261868945);

		// Token: 0x040019C4 RID: 6596
		public static readonly OpCode Brtrue_S = new OpCode(OpCodeValues.Brtrue_S, -261868945);

		// Token: 0x040019C5 RID: 6597
		public static readonly OpCode Beq_S = new OpCode(OpCodeValues.Beq_S, -530308497);

		// Token: 0x040019C6 RID: 6598
		public static readonly OpCode Bge_S = new OpCode(OpCodeValues.Bge_S, -530308497);

		// Token: 0x040019C7 RID: 6599
		public static readonly OpCode Bgt_S = new OpCode(OpCodeValues.Bgt_S, -530308497);

		// Token: 0x040019C8 RID: 6600
		public static readonly OpCode Ble_S = new OpCode(OpCodeValues.Ble_S, -530308497);

		// Token: 0x040019C9 RID: 6601
		public static readonly OpCode Blt_S = new OpCode(OpCodeValues.Blt_S, -530308497);

		// Token: 0x040019CA RID: 6602
		public static readonly OpCode Bne_Un_S = new OpCode(OpCodeValues.Bne_Un_S, -530308497);

		// Token: 0x040019CB RID: 6603
		public static readonly OpCode Bge_Un_S = new OpCode(OpCodeValues.Bge_Un_S, -530308497);

		// Token: 0x040019CC RID: 6604
		public static readonly OpCode Bgt_Un_S = new OpCode(OpCodeValues.Bgt_Un_S, -530308497);

		// Token: 0x040019CD RID: 6605
		public static readonly OpCode Ble_Un_S = new OpCode(OpCodeValues.Ble_Un_S, -530308497);

		// Token: 0x040019CE RID: 6606
		public static readonly OpCode Blt_Un_S = new OpCode(OpCodeValues.Blt_Un_S, -530308497);

		// Token: 0x040019CF RID: 6607
		public static readonly OpCode Br = new OpCode(OpCodeValues.Br, 23333376);

		// Token: 0x040019D0 RID: 6608
		public static readonly OpCode Brfalse = new OpCode(OpCodeValues.Brfalse, -261866912);

		// Token: 0x040019D1 RID: 6609
		public static readonly OpCode Brtrue = new OpCode(OpCodeValues.Brtrue, -261866912);

		// Token: 0x040019D2 RID: 6610
		public static readonly OpCode Beq = new OpCode(OpCodeValues.Beq, -530308512);

		// Token: 0x040019D3 RID: 6611
		public static readonly OpCode Bge = new OpCode(OpCodeValues.Bge, -530308512);

		// Token: 0x040019D4 RID: 6612
		public static readonly OpCode Bgt = new OpCode(OpCodeValues.Bgt, -530308512);

		// Token: 0x040019D5 RID: 6613
		public static readonly OpCode Ble = new OpCode(OpCodeValues.Ble, -530308512);

		// Token: 0x040019D6 RID: 6614
		public static readonly OpCode Blt = new OpCode(OpCodeValues.Blt, -530308512);

		// Token: 0x040019D7 RID: 6615
		public static readonly OpCode Bne_Un = new OpCode(OpCodeValues.Bne_Un, -530308512);

		// Token: 0x040019D8 RID: 6616
		public static readonly OpCode Bge_Un = new OpCode(OpCodeValues.Bge_Un, -530308512);

		// Token: 0x040019D9 RID: 6617
		public static readonly OpCode Bgt_Un = new OpCode(OpCodeValues.Bgt_Un, -530308512);

		// Token: 0x040019DA RID: 6618
		public static readonly OpCode Ble_Un = new OpCode(OpCodeValues.Ble_Un, -530308512);

		// Token: 0x040019DB RID: 6619
		public static readonly OpCode Blt_Un = new OpCode(OpCodeValues.Blt_Un, -530308512);

		// Token: 0x040019DC RID: 6620
		public static readonly OpCode Switch = new OpCode(OpCodeValues.Switch, -261866901);

		// Token: 0x040019DD RID: 6621
		public static readonly OpCode Ldind_I1 = new OpCode(OpCodeValues.Ldind_I1, 6961829);

		// Token: 0x040019DE RID: 6622
		public static readonly OpCode Ldind_U1 = new OpCode(OpCodeValues.Ldind_U1, 6961829);

		// Token: 0x040019DF RID: 6623
		public static readonly OpCode Ldind_I2 = new OpCode(OpCodeValues.Ldind_I2, 6961829);

		// Token: 0x040019E0 RID: 6624
		public static readonly OpCode Ldind_U2 = new OpCode(OpCodeValues.Ldind_U2, 6961829);

		// Token: 0x040019E1 RID: 6625
		public static readonly OpCode Ldind_I4 = new OpCode(OpCodeValues.Ldind_I4, 6961829);

		// Token: 0x040019E2 RID: 6626
		public static readonly OpCode Ldind_U4 = new OpCode(OpCodeValues.Ldind_U4, 6961829);

		// Token: 0x040019E3 RID: 6627
		public static readonly OpCode Ldind_I8 = new OpCode(OpCodeValues.Ldind_I8, 7092901);

		// Token: 0x040019E4 RID: 6628
		public static readonly OpCode Ldind_I = new OpCode(OpCodeValues.Ldind_I, 6961829);

		// Token: 0x040019E5 RID: 6629
		public static readonly OpCode Ldind_R4 = new OpCode(OpCodeValues.Ldind_R4, 7223973);

		// Token: 0x040019E6 RID: 6630
		public static readonly OpCode Ldind_R8 = new OpCode(OpCodeValues.Ldind_R8, 7355045);

		// Token: 0x040019E7 RID: 6631
		public static readonly OpCode Ldind_Ref = new OpCode(OpCodeValues.Ldind_Ref, 7486117);

		// Token: 0x040019E8 RID: 6632
		public static readonly OpCode Stind_Ref = new OpCode(OpCodeValues.Stind_Ref, -530294107);

		// Token: 0x040019E9 RID: 6633
		public static readonly OpCode Stind_I1 = new OpCode(OpCodeValues.Stind_I1, -530294107);

		// Token: 0x040019EA RID: 6634
		public static readonly OpCode Stind_I2 = new OpCode(OpCodeValues.Stind_I2, -530294107);

		// Token: 0x040019EB RID: 6635
		public static readonly OpCode Stind_I4 = new OpCode(OpCodeValues.Stind_I4, -530294107);

		// Token: 0x040019EC RID: 6636
		public static readonly OpCode Stind_I8 = new OpCode(OpCodeValues.Stind_I8, -530290011);

		// Token: 0x040019ED RID: 6637
		public static readonly OpCode Stind_R4 = new OpCode(OpCodeValues.Stind_R4, -530281819);

		// Token: 0x040019EE RID: 6638
		public static readonly OpCode Stind_R8 = new OpCode(OpCodeValues.Stind_R8, -530277723);

		// Token: 0x040019EF RID: 6639
		public static readonly OpCode Add = new OpCode(OpCodeValues.Add, -261739867);

		// Token: 0x040019F0 RID: 6640
		public static readonly OpCode Sub = new OpCode(OpCodeValues.Sub, -261739867);

		// Token: 0x040019F1 RID: 6641
		public static readonly OpCode Mul = new OpCode(OpCodeValues.Mul, -261739867);

		// Token: 0x040019F2 RID: 6642
		public static readonly OpCode Div = new OpCode(OpCodeValues.Div, -261739867);

		// Token: 0x040019F3 RID: 6643
		public static readonly OpCode Div_Un = new OpCode(OpCodeValues.Div_Un, -261739867);

		// Token: 0x040019F4 RID: 6644
		public static readonly OpCode Rem = new OpCode(OpCodeValues.Rem, -261739867);

		// Token: 0x040019F5 RID: 6645
		public static readonly OpCode Rem_Un = new OpCode(OpCodeValues.Rem_Un, -261739867);

		// Token: 0x040019F6 RID: 6646
		public static readonly OpCode And = new OpCode(OpCodeValues.And, -261739867);

		// Token: 0x040019F7 RID: 6647
		public static readonly OpCode Or = new OpCode(OpCodeValues.Or, -261739867);

		// Token: 0x040019F8 RID: 6648
		public static readonly OpCode Xor = new OpCode(OpCodeValues.Xor, -261739867);

		// Token: 0x040019F9 RID: 6649
		public static readonly OpCode Shl = new OpCode(OpCodeValues.Shl, -261739867);

		// Token: 0x040019FA RID: 6650
		public static readonly OpCode Shr = new OpCode(OpCodeValues.Shr, -261739867);

		// Token: 0x040019FB RID: 6651
		public static readonly OpCode Shr_Un = new OpCode(OpCodeValues.Shr_Un, -261739867);

		// Token: 0x040019FC RID: 6652
		public static readonly OpCode Neg = new OpCode(OpCodeValues.Neg, 6691493);

		// Token: 0x040019FD RID: 6653
		public static readonly OpCode Not = new OpCode(OpCodeValues.Not, 6691493);

		// Token: 0x040019FE RID: 6654
		public static readonly OpCode Conv_I1 = new OpCode(OpCodeValues.Conv_I1, 6953637);

		// Token: 0x040019FF RID: 6655
		public static readonly OpCode Conv_I2 = new OpCode(OpCodeValues.Conv_I2, 6953637);

		// Token: 0x04001A00 RID: 6656
		public static readonly OpCode Conv_I4 = new OpCode(OpCodeValues.Conv_I4, 6953637);

		// Token: 0x04001A01 RID: 6657
		public static readonly OpCode Conv_I8 = new OpCode(OpCodeValues.Conv_I8, 7084709);

		// Token: 0x04001A02 RID: 6658
		public static readonly OpCode Conv_R4 = new OpCode(OpCodeValues.Conv_R4, 7215781);

		// Token: 0x04001A03 RID: 6659
		public static readonly OpCode Conv_R8 = new OpCode(OpCodeValues.Conv_R8, 7346853);

		// Token: 0x04001A04 RID: 6660
		public static readonly OpCode Conv_U4 = new OpCode(OpCodeValues.Conv_U4, 6953637);

		// Token: 0x04001A05 RID: 6661
		public static readonly OpCode Conv_U8 = new OpCode(OpCodeValues.Conv_U8, 7084709);

		// Token: 0x04001A06 RID: 6662
		public static readonly OpCode Callvirt = new OpCode(OpCodeValues.Callvirt, 7841348);

		// Token: 0x04001A07 RID: 6663
		public static readonly OpCode Cpobj = new OpCode(OpCodeValues.Cpobj, -530295123);

		// Token: 0x04001A08 RID: 6664
		public static readonly OpCode Ldobj = new OpCode(OpCodeValues.Ldobj, 6698669);

		// Token: 0x04001A09 RID: 6665
		public static readonly OpCode Ldstr = new OpCode(OpCodeValues.Ldstr, 275908266);

		// Token: 0x04001A0A RID: 6666
		public static readonly OpCode Newobj = new OpCode(OpCodeValues.Newobj, 276014660);

		// Token: 0x04001A0B RID: 6667
		public static readonly OpCode Castclass = new OpCode(OpCodeValues.Castclass, 7513773);

		// Token: 0x04001A0C RID: 6668
		public static readonly OpCode Isinst = new OpCode(OpCodeValues.Isinst, 6989485);

		// Token: 0x04001A0D RID: 6669
		public static readonly OpCode Conv_R_Un = new OpCode(OpCodeValues.Conv_R_Un, 7346853);

		// Token: 0x04001A0E RID: 6670
		public static readonly OpCode Unbox = new OpCode(OpCodeValues.Unbox, 6990509);

		// Token: 0x04001A0F RID: 6671
		public static readonly OpCode Throw = new OpCode(OpCodeValues.Throw, -245061883);

		// Token: 0x04001A10 RID: 6672
		public static readonly OpCode Ldfld = new OpCode(OpCodeValues.Ldfld, 6727329);

		// Token: 0x04001A11 RID: 6673
		public static readonly OpCode Ldflda = new OpCode(OpCodeValues.Ldflda, 6989473);

		// Token: 0x04001A12 RID: 6674
		public static readonly OpCode Stfld = new OpCode(OpCodeValues.Stfld, -530270559);

		// Token: 0x04001A13 RID: 6675
		public static readonly OpCode Ldsfld = new OpCode(OpCodeValues.Ldsfld, 275121825);

		// Token: 0x04001A14 RID: 6676
		public static readonly OpCode Ldsflda = new OpCode(OpCodeValues.Ldsflda, 275383969);

		// Token: 0x04001A15 RID: 6677
		public static readonly OpCode Stsfld = new OpCode(OpCodeValues.Stsfld, -261876063);

		// Token: 0x04001A16 RID: 6678
		public static readonly OpCode Stobj = new OpCode(OpCodeValues.Stobj, -530298195);

		// Token: 0x04001A17 RID: 6679
		public static readonly OpCode Conv_Ovf_I1_Un = new OpCode(OpCodeValues.Conv_Ovf_I1_Un, 6953637);

		// Token: 0x04001A18 RID: 6680
		public static readonly OpCode Conv_Ovf_I2_Un = new OpCode(OpCodeValues.Conv_Ovf_I2_Un, 6953637);

		// Token: 0x04001A19 RID: 6681
		public static readonly OpCode Conv_Ovf_I4_Un = new OpCode(OpCodeValues.Conv_Ovf_I4_Un, 6953637);

		// Token: 0x04001A1A RID: 6682
		public static readonly OpCode Conv_Ovf_I8_Un = new OpCode(OpCodeValues.Conv_Ovf_I8_Un, 7084709);

		// Token: 0x04001A1B RID: 6683
		public static readonly OpCode Conv_Ovf_U1_Un = new OpCode(OpCodeValues.Conv_Ovf_U1_Un, 6953637);

		// Token: 0x04001A1C RID: 6684
		public static readonly OpCode Conv_Ovf_U2_Un = new OpCode(OpCodeValues.Conv_Ovf_U2_Un, 6953637);

		// Token: 0x04001A1D RID: 6685
		public static readonly OpCode Conv_Ovf_U4_Un = new OpCode(OpCodeValues.Conv_Ovf_U4_Un, 6953637);

		// Token: 0x04001A1E RID: 6686
		public static readonly OpCode Conv_Ovf_U8_Un = new OpCode(OpCodeValues.Conv_Ovf_U8_Un, 7084709);

		// Token: 0x04001A1F RID: 6687
		public static readonly OpCode Conv_Ovf_I_Un = new OpCode(OpCodeValues.Conv_Ovf_I_Un, 6953637);

		// Token: 0x04001A20 RID: 6688
		public static readonly OpCode Conv_Ovf_U_Un = new OpCode(OpCodeValues.Conv_Ovf_U_Un, 6953637);

		// Token: 0x04001A21 RID: 6689
		public static readonly OpCode Box = new OpCode(OpCodeValues.Box, 7477933);

		// Token: 0x04001A22 RID: 6690
		public static readonly OpCode Newarr = new OpCode(OpCodeValues.Newarr, 7485101);

		// Token: 0x04001A23 RID: 6691
		public static readonly OpCode Ldlen = new OpCode(OpCodeValues.Ldlen, 6989477);

		// Token: 0x04001A24 RID: 6692
		public static readonly OpCode Ldelema = new OpCode(OpCodeValues.Ldelema, -261437779);

		// Token: 0x04001A25 RID: 6693
		public static readonly OpCode Ldelem_I1 = new OpCode(OpCodeValues.Ldelem_I1, -261437787);

		// Token: 0x04001A26 RID: 6694
		public static readonly OpCode Ldelem_U1 = new OpCode(OpCodeValues.Ldelem_U1, -261437787);

		// Token: 0x04001A27 RID: 6695
		public static readonly OpCode Ldelem_I2 = new OpCode(OpCodeValues.Ldelem_I2, -261437787);

		// Token: 0x04001A28 RID: 6696
		public static readonly OpCode Ldelem_U2 = new OpCode(OpCodeValues.Ldelem_U2, -261437787);

		// Token: 0x04001A29 RID: 6697
		public static readonly OpCode Ldelem_I4 = new OpCode(OpCodeValues.Ldelem_I4, -261437787);

		// Token: 0x04001A2A RID: 6698
		public static readonly OpCode Ldelem_U4 = new OpCode(OpCodeValues.Ldelem_U4, -261437787);

		// Token: 0x04001A2B RID: 6699
		public static readonly OpCode Ldelem_I8 = new OpCode(OpCodeValues.Ldelem_I8, -261306715);

		// Token: 0x04001A2C RID: 6700
		public static readonly OpCode Ldelem_I = new OpCode(OpCodeValues.Ldelem_I, -261437787);

		// Token: 0x04001A2D RID: 6701
		public static readonly OpCode Ldelem_R4 = new OpCode(OpCodeValues.Ldelem_R4, -261175643);

		// Token: 0x04001A2E RID: 6702
		public static readonly OpCode Ldelem_R8 = new OpCode(OpCodeValues.Ldelem_R8, -261044571);

		// Token: 0x04001A2F RID: 6703
		public static readonly OpCode Ldelem_Ref = new OpCode(OpCodeValues.Ldelem_Ref, -260913499);

		// Token: 0x04001A30 RID: 6704
		public static readonly OpCode Stelem_I = new OpCode(OpCodeValues.Stelem_I, -798697819);

		// Token: 0x04001A31 RID: 6705
		public static readonly OpCode Stelem_I1 = new OpCode(OpCodeValues.Stelem_I1, -798697819);

		// Token: 0x04001A32 RID: 6706
		public static readonly OpCode Stelem_I2 = new OpCode(OpCodeValues.Stelem_I2, -798697819);

		// Token: 0x04001A33 RID: 6707
		public static readonly OpCode Stelem_I4 = new OpCode(OpCodeValues.Stelem_I4, -798697819);

		// Token: 0x04001A34 RID: 6708
		public static readonly OpCode Stelem_I8 = new OpCode(OpCodeValues.Stelem_I8, -798693723);

		// Token: 0x04001A35 RID: 6709
		public static readonly OpCode Stelem_R4 = new OpCode(OpCodeValues.Stelem_R4, -798689627);

		// Token: 0x04001A36 RID: 6710
		public static readonly OpCode Stelem_R8 = new OpCode(OpCodeValues.Stelem_R8, -798685531);

		// Token: 0x04001A37 RID: 6711
		public static readonly OpCode Stelem_Ref = new OpCode(OpCodeValues.Stelem_Ref, -798681435);

		// Token: 0x04001A38 RID: 6712
		public static readonly OpCode Ldelem = new OpCode(OpCodeValues.Ldelem, -261699923);

		// Token: 0x04001A39 RID: 6713
		public static readonly OpCode Stelem = new OpCode(OpCodeValues.Stelem, -798636371);

		// Token: 0x04001A3A RID: 6714
		public static readonly OpCode Unbox_Any = new OpCode(OpCodeValues.Unbox_Any, 6727341);

		// Token: 0x04001A3B RID: 6715
		public static readonly OpCode Conv_Ovf_I1 = new OpCode(OpCodeValues.Conv_Ovf_I1, 6953637);

		// Token: 0x04001A3C RID: 6716
		public static readonly OpCode Conv_Ovf_U1 = new OpCode(OpCodeValues.Conv_Ovf_U1, 6953637);

		// Token: 0x04001A3D RID: 6717
		public static readonly OpCode Conv_Ovf_I2 = new OpCode(OpCodeValues.Conv_Ovf_I2, 6953637);

		// Token: 0x04001A3E RID: 6718
		public static readonly OpCode Conv_Ovf_U2 = new OpCode(OpCodeValues.Conv_Ovf_U2, 6953637);

		// Token: 0x04001A3F RID: 6719
		public static readonly OpCode Conv_Ovf_I4 = new OpCode(OpCodeValues.Conv_Ovf_I4, 6953637);

		// Token: 0x04001A40 RID: 6720
		public static readonly OpCode Conv_Ovf_U4 = new OpCode(OpCodeValues.Conv_Ovf_U4, 6953637);

		// Token: 0x04001A41 RID: 6721
		public static readonly OpCode Conv_Ovf_I8 = new OpCode(OpCodeValues.Conv_Ovf_I8, 7084709);

		// Token: 0x04001A42 RID: 6722
		public static readonly OpCode Conv_Ovf_U8 = new OpCode(OpCodeValues.Conv_Ovf_U8, 7084709);

		// Token: 0x04001A43 RID: 6723
		public static readonly OpCode Refanyval = new OpCode(OpCodeValues.Refanyval, 6953645);

		// Token: 0x04001A44 RID: 6724
		public static readonly OpCode Ckfinite = new OpCode(OpCodeValues.Ckfinite, 7346853);

		// Token: 0x04001A45 RID: 6725
		public static readonly OpCode Mkrefany = new OpCode(OpCodeValues.Mkrefany, 6699693);

		// Token: 0x04001A46 RID: 6726
		public static readonly OpCode Ldtoken = new OpCode(OpCodeValues.Ldtoken, 275385004);

		// Token: 0x04001A47 RID: 6727
		public static readonly OpCode Conv_U2 = new OpCode(OpCodeValues.Conv_U2, 6953637);

		// Token: 0x04001A48 RID: 6728
		public static readonly OpCode Conv_U1 = new OpCode(OpCodeValues.Conv_U1, 6953637);

		// Token: 0x04001A49 RID: 6729
		public static readonly OpCode Conv_I = new OpCode(OpCodeValues.Conv_I, 6953637);

		// Token: 0x04001A4A RID: 6730
		public static readonly OpCode Conv_Ovf_I = new OpCode(OpCodeValues.Conv_Ovf_I, 6953637);

		// Token: 0x04001A4B RID: 6731
		public static readonly OpCode Conv_Ovf_U = new OpCode(OpCodeValues.Conv_Ovf_U, 6953637);

		// Token: 0x04001A4C RID: 6732
		public static readonly OpCode Add_Ovf = new OpCode(OpCodeValues.Add_Ovf, -261739867);

		// Token: 0x04001A4D RID: 6733
		public static readonly OpCode Add_Ovf_Un = new OpCode(OpCodeValues.Add_Ovf_Un, -261739867);

		// Token: 0x04001A4E RID: 6734
		public static readonly OpCode Mul_Ovf = new OpCode(OpCodeValues.Mul_Ovf, -261739867);

		// Token: 0x04001A4F RID: 6735
		public static readonly OpCode Mul_Ovf_Un = new OpCode(OpCodeValues.Mul_Ovf_Un, -261739867);

		// Token: 0x04001A50 RID: 6736
		public static readonly OpCode Sub_Ovf = new OpCode(OpCodeValues.Sub_Ovf, -261739867);

		// Token: 0x04001A51 RID: 6737
		public static readonly OpCode Sub_Ovf_Un = new OpCode(OpCodeValues.Sub_Ovf_Un, -261739867);

		// Token: 0x04001A52 RID: 6738
		public static readonly OpCode Endfinally = new OpCode(OpCodeValues.Endfinally, 23333605);

		// Token: 0x04001A53 RID: 6739
		public static readonly OpCode Leave = new OpCode(OpCodeValues.Leave, 23333376);

		// Token: 0x04001A54 RID: 6740
		public static readonly OpCode Leave_S = new OpCode(OpCodeValues.Leave_S, 23333391);

		// Token: 0x04001A55 RID: 6741
		public static readonly OpCode Stind_I = new OpCode(OpCodeValues.Stind_I, -530294107);

		// Token: 0x04001A56 RID: 6742
		public static readonly OpCode Conv_U = new OpCode(OpCodeValues.Conv_U, 6953637);

		// Token: 0x04001A57 RID: 6743
		public static readonly OpCode Prefix7 = new OpCode(OpCodeValues.Prefix7, 6554757);

		// Token: 0x04001A58 RID: 6744
		public static readonly OpCode Prefix6 = new OpCode(OpCodeValues.Prefix6, 6554757);

		// Token: 0x04001A59 RID: 6745
		public static readonly OpCode Prefix5 = new OpCode(OpCodeValues.Prefix5, 6554757);

		// Token: 0x04001A5A RID: 6746
		public static readonly OpCode Prefix4 = new OpCode(OpCodeValues.Prefix4, 6554757);

		// Token: 0x04001A5B RID: 6747
		public static readonly OpCode Prefix3 = new OpCode(OpCodeValues.Prefix3, 6554757);

		// Token: 0x04001A5C RID: 6748
		public static readonly OpCode Prefix2 = new OpCode(OpCodeValues.Prefix2, 6554757);

		// Token: 0x04001A5D RID: 6749
		public static readonly OpCode Prefix1 = new OpCode(OpCodeValues.Prefix1, 6554757);

		// Token: 0x04001A5E RID: 6750
		public static readonly OpCode Prefixref = new OpCode(OpCodeValues.Prefixref, 6554757);

		// Token: 0x04001A5F RID: 6751
		public static readonly OpCode Arglist = new OpCode(OpCodeValues.Arglist, 279579301);

		// Token: 0x04001A60 RID: 6752
		public static readonly OpCode Ceq = new OpCode(OpCodeValues.Ceq, -257283419);

		// Token: 0x04001A61 RID: 6753
		public static readonly OpCode Cgt = new OpCode(OpCodeValues.Cgt, -257283419);

		// Token: 0x04001A62 RID: 6754
		public static readonly OpCode Cgt_Un = new OpCode(OpCodeValues.Cgt_Un, -257283419);

		// Token: 0x04001A63 RID: 6755
		public static readonly OpCode Clt = new OpCode(OpCodeValues.Clt, -257283419);

		// Token: 0x04001A64 RID: 6756
		public static readonly OpCode Clt_Un = new OpCode(OpCodeValues.Clt_Un, -257283419);

		// Token: 0x04001A65 RID: 6757
		public static readonly OpCode Ldftn = new OpCode(OpCodeValues.Ldftn, 279579300);

		// Token: 0x04001A66 RID: 6758
		public static readonly OpCode Ldvirtftn = new OpCode(OpCodeValues.Ldvirtftn, 11184804);

		// Token: 0x04001A67 RID: 6759
		public static readonly OpCode Ldarg = new OpCode(OpCodeValues.Ldarg, 279317166);

		// Token: 0x04001A68 RID: 6760
		public static readonly OpCode Ldarga = new OpCode(OpCodeValues.Ldarga, 279579310);

		// Token: 0x04001A69 RID: 6761
		public static readonly OpCode Starg = new OpCode(OpCodeValues.Starg, -257680722);

		// Token: 0x04001A6A RID: 6762
		public static readonly OpCode Ldloc = new OpCode(OpCodeValues.Ldloc, 279317166);

		// Token: 0x04001A6B RID: 6763
		public static readonly OpCode Ldloca = new OpCode(OpCodeValues.Ldloca, 279579310);

		// Token: 0x04001A6C RID: 6764
		public static readonly OpCode Stloc = new OpCode(OpCodeValues.Stloc, -257680722);

		// Token: 0x04001A6D RID: 6765
		public static readonly OpCode Localloc = new OpCode(OpCodeValues.Localloc, 11156133);

		// Token: 0x04001A6E RID: 6766
		public static readonly OpCode Endfilter = new OpCode(OpCodeValues.Endfilter, -240895259);

		// Token: 0x04001A6F RID: 6767
		public static readonly OpCode Unaligned = new OpCode(OpCodeValues.Unaligned_, 10750096);

		// Token: 0x04001A70 RID: 6768
		public static readonly OpCode Volatile = new OpCode(OpCodeValues.Volatile_, 10750085);

		// Token: 0x04001A71 RID: 6769
		public static readonly OpCode Tailcall = new OpCode(OpCodeValues.Tail_, 10750085);

		// Token: 0x04001A72 RID: 6770
		public static readonly OpCode Initobj = new OpCode(OpCodeValues.Initobj, -257673555);

		// Token: 0x04001A73 RID: 6771
		public static readonly OpCode Constrained = new OpCode(OpCodeValues.Constrained_, 10750093);

		// Token: 0x04001A74 RID: 6772
		public static readonly OpCode Cpblk = new OpCode(OpCodeValues.Cpblk, -794527067);

		// Token: 0x04001A75 RID: 6773
		public static readonly OpCode Initblk = new OpCode(OpCodeValues.Initblk, -794527067);

		// Token: 0x04001A76 RID: 6774
		public static readonly OpCode Rethrow = new OpCode(OpCodeValues.Rethrow, 27526917);

		// Token: 0x04001A77 RID: 6775
		public static readonly OpCode Sizeof = new OpCode(OpCodeValues.Sizeof, 279579309);

		// Token: 0x04001A78 RID: 6776
		public static readonly OpCode Refanytype = new OpCode(OpCodeValues.Refanytype, 11147941);

		// Token: 0x04001A79 RID: 6777
		public static readonly OpCode Readonly = new OpCode(OpCodeValues.Readonly_, 10750085);
	}
}
